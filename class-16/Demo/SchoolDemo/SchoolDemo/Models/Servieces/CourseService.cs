using Microsoft.EntityFrameworkCore;
using SchoolDemo.Data;
using SchoolDemo.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Servieces
{
    public class CourseService : ICourse
    {
        private readonly SchoolDbContext _context;

        public CourseService(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task<Course> Create(Course course)
        {
            _context.Entry(course).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return course;
        }
        public async Task<List<Course>> GetCourses()
        {
            //var courses = await _context.Courses.ToListAsync();
            //return courses;

            return await _context.Courses
                                  .Include(e => e.Enrollments)
                                  .ThenInclude(s => s.Student)
                                  .ToListAsync();
        }
        public async Task<Course> GetCourse(int id)
        {
            //var course = await _context.Courses.FindAsync(id);
            //return course;
            return await _context.Courses
                                 .Include(e => e.Enrollments)
                                 .ThenInclude(s => s.Student)
                                 .FirstOrDefaultAsync(x=> x.Id == id);
        }

        public async Task<Course> GetCourseByCode (string code)
        {
            return await _context.Courses
                                .Include(e => e.Enrollments)
                                .ThenInclude(s => s.Student)
                                .FirstOrDefaultAsync(x => x.CourseCode == code);
        }
        public async Task<Course> UpdateCourse(int id, Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task Delete(int id)
        {
            Course course = await GetCourse(id);
            _context.Entry(course).State = EntityState.Detached;
            await _context.SaveChangesAsync();
        }

        public async Task AddStudentToCourse(int courseId, int studentId)
        {
            Enrollment enrollment = new Enrollment
            {
                CourseId = courseId,
                StudentId = studentId
            };
            _context.Entry(enrollment).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }
    }
}
