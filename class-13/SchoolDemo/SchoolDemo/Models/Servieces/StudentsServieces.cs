using Microsoft.EntityFrameworkCore;
using SchoolDemo.Data;
using SchoolDemo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Servieces
{
   
    public class StudentsServieces: IStudent
    {
        private readonly SchoolDbContext _context;

        public StudentsServieces(SchoolDbContext context)
        {
            _context = context;
        }


        public async Task<Student> Create( Student student)
        {
            _context.Entry(student).State = EntityState.Added;

            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<Student> GetStudent(int id)
        {
            Student student = await _context.Students.FindAsync(id);

            return student;
        }

        public async Task<List<Student>> GetStudents()
        {
            var students = await _context.Students.ToListAsync();
            return students;
        }

        public async Task<Student> UpdateStudent(int id, Student student)
        {
            _context.Entry(student).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return student;
        }

        public async Task Delete(int id)
        {
            Student student = await GetStudent(id);

            _context.Entry(student).State = EntityState.Deleted;

            await _context.SaveChangesAsync();


        }
    }
}
