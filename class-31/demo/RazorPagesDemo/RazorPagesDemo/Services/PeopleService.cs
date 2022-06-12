using Microsoft.EntityFrameworkCore;
using RazorPagesDemo.Data;
using RazorPagesDemo.Models;
using RazorPagesDemo.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorPagesDemo.Services
{
    public class PeopleService : IPerson
    {
        private RazorDbContext _context;

        public PeopleService(RazorDbContext razorDbContext)
        {
            _context = razorDbContext;
        }
        public async Task<Person> Create(Person person)
        {
            _context.Entry(person).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task<List<Person>> GetAll()
        {
           return await _context.people.ToListAsync();
        }
    }
}
