using Microsoft.EntityFrameworkCore;
using SchoolDemo.Data;
using SchoolDemo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Models.Servieces
{
    public class TechnologyServieces: ITechnology
    {
        private readonly SchoolDbContext _context;

        public TechnologyServieces(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task<List<Technology>> GetTechnologies()
        {
            return await _context.Technologies.ToListAsync();
        }
    }
}
