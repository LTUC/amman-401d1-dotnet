using Microsoft.EntityFrameworkCore;
using SchoolDemo.Models;

namespace SchoolDemo.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public SchoolDbContext(DbContextOptions options) : base(options)
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
                new Student { Id = 1, Firstname = "Ahmad", LastName = "Almohammad" },
                new Student { Id = 2, Firstname = "Sultan", LastName = "Kanaan" }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, CourseCode = "asac-dn-01", TechnologyId = 1 },
                new Course { Id = 2, CourseCode = "asac-dn-02", TechnologyId = 2 },
                new Course { Id = 3, CourseCode = "asac-py-02", TechnologyId = 2 }
                );

            modelBuilder.Entity<Enrollment>().HasKey(
                enrollment => new { enrollment.CourseId, enrollment.StudentId }
                );
        }
    }
}
