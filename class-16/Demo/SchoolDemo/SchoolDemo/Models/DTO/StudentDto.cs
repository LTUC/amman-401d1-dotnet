using System.Collections.Generic;

namespace SchoolDemo.Models.DTO
{
    public class StudentDto
    {
 
        public int Id { get; set; }
       
        public string Firstname { get; set; }
       
        public string LastName { get; set; }

        public List<CourseDto> Courses { get; set; }
    }
}
