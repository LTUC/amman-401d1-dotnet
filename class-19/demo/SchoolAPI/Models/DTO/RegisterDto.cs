using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models.DTO
{
    public class RegisterDto
    {
        [Required(ErrorMessage ="You have missed to fill the username")]
        [Display(Name ="User Name")]
        [MinLength(3)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public string Gender { get; set; }
    }
}
