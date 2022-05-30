using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models
{
    public class Enrollment
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        // Navigation Properties
        // it will specfiy thelink between these tables 

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
