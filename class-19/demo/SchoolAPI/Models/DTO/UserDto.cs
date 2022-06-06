using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models.DTO
{
    // We did not use this in the demo
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string Token { get; set; }

        public IList<string> Roles { get; set; }
    }
}
