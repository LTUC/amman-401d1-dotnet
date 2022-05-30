using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Interfaces
{
    public interface ICourse
    {
        Task<Course> Create(Course course);

        Task<List<Course>> GetCourses();

        Task<Course> GetCourse(int id);

        Task<Course> GetCourseByCode(string code);

        Task<Course> UpdateCourse(int id, Course course);

        Task Delete(int id);

        Task AddStudentToCourse(int courseId, int studentId);
    }
}
