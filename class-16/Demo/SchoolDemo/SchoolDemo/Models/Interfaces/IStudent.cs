using SchoolDemo.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Interfaces
{
    public interface IStudent
    {
        Task<StudentDto> Create(NewStudentDto student);
        Task<List<StudentDto>> GetStudents();
        Task<StudentDto> GetStudent(int id);
        Task<Student> UpdateStudent(int id, Student student);
        Task Delete(int id);

    }
}
