using Microsoft.AspNetCore.Mvc.ModelBinding;
using SchoolAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SchoolAPI.Models.Interfaces
{
    public interface IUserService
    {
        public Task<UserDto> Register(RegisterDto registerDto, ModelStateDictionary modelstate);
        public Task<UserDto> Authenticate(string username, string password);
        public Task<UserDto> GetUser(ClaimsPrincipal principal);

    }   
}
