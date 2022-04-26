using Microsoft.EntityFrameworkCore;
using SchoolDemo.Data;
using SchoolDemo.Models.DTO;
using SchoolDemo.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Servieces
{

    public class StudentsServieces : IStudent
    {
        private readonly SchoolDbContext _context;
        private readonly ICourse _courses;

        public StudentsServieces(SchoolDbContext context, ICourse courses)
        {
            _context = context;
            _courses = courses;
        }


        public async Task<StudentDto> Create(NewStudentDto newStudent)
        {

            Student createdStudent = new Student
            {
                Firstname = newStudent.FullName.Split(" ").First<string>(),
                LastName = newStudent.FullName.Split(" ").Last<string>()

            };
            _context.Entry(createdStudent).State = EntityState.Added;

            await _context.SaveChangesAsync();

            Course course = await _courses.GetCourseByCode(newStudent.CourseCode);
            await _courses.AddStudentToCourse(course.Id, createdStudent.Id);
            StudentDto studentDto = await GetStudent(createdStudent.Id);
            return studentDto;
        }

        public async Task<StudentDto> GetStudent(int id)
        {
            //Student student = await _context.Students.FindAsync(id);

            //return student;


            //Student student = await _context.Students.FindAsync(id);
            //var enrollment = await _context.Enrollments.Where(x => x.StudentId == id)
            //                                           .Include(x => x.Course)
            //                                           .ToListAsync();
            //student.Enrollments = enrollment;
            //return student;


            //return await _context.Students
            //                     .Include(e => e.Enrollments)
            //                     .ThenInclude(c => c.Course)
            //                     .FirstOrDefaultAsync(a => a.Id == id);


            return await _context.Students
                .Select(student => new StudentDto
                {
                    Id = student.Id,
                    Firstname = student.Firstname,
                    LastName = student.LastName,
                    Courses = student.Enrollments
                    .Select(x => new CourseDto
                    {
                        CouresCode = x.Course.CourseCode,
                        Technology = x.Course.Technology.Name
                    }).ToList()

                }).FirstOrDefaultAsync(s => s.Id == id);


        }

        public async Task<List<StudentDto>> GetStudents()
        {

            //return await _context.Students
            //                     .Include(e => e.Enrollments)
            //                     .ThenInclude(c => c.Course)
            //                     .ToListAsync();
            return await _context.Students
               .Select(student => new StudentDto
               {
                   Id = student.Id,
                   Firstname = student.Firstname,
                   LastName = student.LastName,
                   Courses = student.Enrollments
                   .Select(x => new CourseDto
                   {
                       CouresCode = x.Course.CourseCode,
                       Technology = x.Course.Technology.Name
                   }).ToList()

               }).ToListAsync();
        }

        public async Task<Student> UpdateStudent(int id, Student student)
        {
            _context.Entry(student).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return student;
        }

        public async Task Delete(int id)
        {
            Student student = await _context.Students.FindAsync(id);

            _context.Entry(student).State = EntityState.Deleted;

            await _context.SaveChangesAsync();


        }
    }
}
