using Microsoft.EntityFrameworkCore;
using SchoolDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemo.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public SchoolDbContext( DbContextOptions options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This calls the base method, but does nothing
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Technology>().HasData(
              new Technology { id = 1, Name = ".NET " },
              new Technology { id = 2, Name = "Node.js" }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { id = 1, Firstname = "Ahmad", LastName = "Almohammad" },
                new Student { id = 2, Firstname = "Sultan", LastName = "Kanaan" }
                );
        }
    }
}
