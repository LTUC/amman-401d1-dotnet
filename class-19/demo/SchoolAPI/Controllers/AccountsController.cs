using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models.DTO;
using SchoolAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IUserService _userService;
        public AccountsController(IUserService userService)
        {
            _userService = userService;
        }

        // in Node.js -->
        //  requset.body
        //  requst.query
        //  request.params

        [HttpPost("Register")]
        public async Task <ActionResult> Register([FromBody] RegisterDto registerDto)
        {
            try
            {
                
                await _userService.Register(registerDto, this.ModelState);
                if (ModelState.IsValid)
                {
                    return Ok("Registered done");

                }
                return BadRequest(new ValidationProblemDetails(ModelState));
                //return Ok("A User hase beed registed successfully");

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        [HttpPost("Login")]
        public async Task <ActionResult<UserDto>> Login(LoginDTO loginDTO)
        {
            var user = await _userService.Authenticate(loginDTO.UserName, loginDTO.Password);

            if (user == null)
            {
                return Unauthorized();
            }

            return user;
        }

        
        [HttpGet("me")]
        [Authorize(Policy = "create")]
        public async Task<ActionResult<UserDto>> Me()
        {
            // Following the [Authorize] phase, this.User will be ... you.
            // Put a breakpoint here and inspect to see what's passed to our getUser method
            return await _userService.GetUser(this.User);
        }
    }
}
