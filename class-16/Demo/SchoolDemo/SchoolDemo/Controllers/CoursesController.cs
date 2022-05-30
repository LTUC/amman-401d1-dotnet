using Microsoft.AspNetCore.Mvc;
using SchoolDemo.Models;
using SchoolDemo.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourse _course;

        public CoursesController(ICourse course)
        {
            _course = course;
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            var CoursesList = await _course.GetCourses();
            return Ok(CoursesList);
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            var Course = await _course.GetCourse(id);
            return Ok(Course);
        }

        // PUT: api/Courses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(int id, Course course)
        {
            if (id != course.Id)
            {
                return NoContent();
            }
            var updatedCourse = await _course.UpdateCourse(id, course);
            return Ok(updatedCourse);

        }

        // POST: api/Courses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {

            await _course.Create(course);
            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            await _course.Delete(id);
            return NoContent();
        }

        // add student to course: api/Courses/1/2
        [HttpPost("{courseId}/{studentId}")]
        public async Task<IActionResult> AddStudentToCourse (int courseId, int studentId)
        {
            await _course.AddStudentToCourse(courseId, studentId);
            return NoContent();
        }

    }
}
