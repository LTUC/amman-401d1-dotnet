using Microsoft.AspNetCore.Mvc;
using SchoolDemo.Models;
using SchoolDemo.Models.DTO;
using SchoolDemo.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudent _student;

        public StudentsController(IStudent student)
        {
            _student = student;
        }

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetStudents()
        {
            var students =  await _student.GetStudents();
            return Ok(students);
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> GetStudent(int id)
        {
            StudentDto student = await _student.GetStudent(id);
            return Ok(student);
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }

            var modifiedStudent = await _student.UpdateStudent(id, student);

            return Ok(modifiedStudent);

            
        }

        // POST: api/Students
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentDto>> PostStudent(NewStudentDto student)
        {
            StudentDto newStudent = await _student.Create(student);
            return Ok(newStudent);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            await _student.Delete(id);

            return NoContent();
        }

    }
}
