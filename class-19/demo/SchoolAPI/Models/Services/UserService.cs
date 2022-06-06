using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SchoolAPI.Models.DTO;
using SchoolAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SchoolAPI.Models.Services
{
    public class UserService : IUserService
    {
        private UserManager<ApplicationUser> _userManager;
        private JwtTokenService tokenService;

        public UserService(UserManager<ApplicationUser> userManager, JwtTokenService jwtTokenService)
        {
            _userManager = userManager;
            tokenService = jwtTokenService;
        }
        public async Task<UserDto> Register(RegisterDto registerDto, ModelStateDictionary modelstate)
        {
            var user = new ApplicationUser
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email,
                Gender = registerDto.Gender,
                //PasswordHash = registerDto.Password 
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);
                    
            if (result.Succeeded)
            {
                // here goes the roles specifications ... 
                IList<string> Roles = new List<string>();
                Roles.Add("user");
                await _userManager.AddToRolesAsync(user, Roles);

                return new UserDto
                {
                    Username = user.UserName,
                    Token = await tokenService.GetToken(user, System.TimeSpan.FromDays(2)),
                    Roles = await _userManager.GetRolesAsync(user)
                };
            }
            // // Else, that means there is an error, let us collect all the errors using the modelState
            foreach (var error in result.Errors)
            {
                var errorKey =
                    error.Code.Contains("Password") ? "Password Issue" :
                    error.Code.Contains("Email") ? "Email Issue" :
                    error.Code.Contains("UserName") ? nameof(registerDto.UserName) :
                    "";

                modelstate.AddModelError(errorKey, error.Description);
            }
            return null;
  
            
        }

        public async Task<UserDto> Authenticate(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (await _userManager.CheckPasswordAsync(user, password))
            {
                return new UserDto
                {
                    Username = user.UserName,
                    Token = await tokenService.GetToken(user, System.TimeSpan.FromDays(2)),
                    Roles = await _userManager.GetRolesAsync(user)
                };
            }

            return null;
        }

        public async Task<UserDto> GetUser(ClaimsPrincipal principal)
        {
            var user = await _userManager.GetUserAsync(principal);
            return new UserDto
            {
                Username = user.UserName
            };
        }
    }
}
