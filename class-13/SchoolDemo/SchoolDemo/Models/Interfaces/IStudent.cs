using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Interfaces
{
    public interface IStudent
    {
        Task<Student> Create(Student student);
        Task<List<Student>> GetStudents();
        Task<Student> GetStudent(int id);
        Task<Student> UpdateStudent(int id, Student student);
        Task Delete(int id);

    }
}
