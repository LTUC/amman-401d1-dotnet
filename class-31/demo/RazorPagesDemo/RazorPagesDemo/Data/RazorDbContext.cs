using Microsoft.EntityFrameworkCore;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Data
{
    public class RazorDbContext : DbContext
    {
        public RazorDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { Id=1, Name = "Hanan", Age = 25},
                new Person { Id = 2, Name = "Yahia", Age = 29 },
                new Person { Id = 3, Name = "Ola", Age = 31 },
                new Person { Id = 4, Name = "Bashar", Age = 35 }
                );
        }

        public DbSet<Person> people {get; set;}
    }
}
