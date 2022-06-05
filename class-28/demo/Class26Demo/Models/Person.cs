using System.ComponentModel.DataAnnotations;

namespace Class26Demo.Models
{
    public class Person
    {
        public int Id{ get; set; }
        [Required]
        public string Name { get; set; }
        public string Job { get; set; }
    }
}
