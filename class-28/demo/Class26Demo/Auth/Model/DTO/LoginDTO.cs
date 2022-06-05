using System.ComponentModel.DataAnnotations;

namespace Class26Demo.Auth.Model.DTO
{
    // As is 
    public class LoginDTO
    {
        [Required]
        public string UserName{ get; set; }
        [Required]
        public string Password { get; set; }
    }
}
