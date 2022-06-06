using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data;
using SchoolAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models.Services
{
  public class TechnologyService : ITechnology
  {
    private SchoolDbContext _context;

    public TechnologyService(SchoolDbContext context)
    {
      _context = context;
    }
        public async Task<Technology> Create(Technology technology)
        {


            _context.Entry(technology).State = EntityState.Added;
            // the current state of the technology object: added

            await _context.SaveChangesAsync();

            var tech = new Technology
            {
                Id = 3,
                Name = "ASP.net"
            };

            var user = new IdentityUser
            {
                UserName = "Fadi",
                Email = "asda@asd",
                
            };

            var user2 = new ApplicationUser
            {
                UserName = "Fadi",
                Email = "asda@asd",
                Gender = "Male"

            };
            _context.Entry(user).State = EntityState.Added;

            return technology;
    }


    public async Task<List<Technology>> GetTechnologies()
    {
      var technologies = await _context.Technologies.ToListAsync();
      return technologies;
    }

    public async Task<Technology> GetTechnology(int id)
    {
      Technology technology = await _context.Technologies.FindAsync(id);
      return technology;
    }

    public async Task<Technology> UpdateTechnology(int id, Technology technology)
    {
      _context.Entry(technology).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return technology;
    }

    public async Task Delete(int id)
    {
      Technology technology = await GetTechnology(id);
      _context.Entry(technology).State = EntityState.Deleted;
      await _context.SaveChangesAsync();
    }



  }
}
