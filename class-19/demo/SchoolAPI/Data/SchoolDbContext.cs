using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Data
{
  public class SchoolDbContext : IdentityDbContext<ApplicationUser>
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

      // This calls the base method, and Identity needs it
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Student>().HasData(
        new Student { Id = 1, FirstName = "John", LastName = "Cokos" }
      );

      modelBuilder.Entity<Course>().HasData(
        new Course { Id = 1, CourseCode = "seattle-dotnet-401d13", TechnologyId = 3 },
        new Course { Id = 2, CourseCode = "seattle-javascript-401n18", TechnologyId = 1 },
        new Course { Id = 3, CourseCode = "seattle-code-201d73", TechnologyId = 1 }
      );

      modelBuilder.Entity<Technology>().HasData(
        new Technology { Id = 1, Name = "Javascript" },
        new Technology { Id = 2, Name = "Python" },
        new Technology { Id = 3, Name = "C#" },
        new Technology { Id = 4, Name = "Java" }
      );

            SeedRoles(modelBuilder, "administrator","create","update","delete");
            SeedRoles(modelBuilder, "editor", "create","update");
            SeedRoles(modelBuilder, "user", "create");

            modelBuilder.Entity<Enrollment>().HasKey(
        enrollment => new { enrollment.CourseId, enrollment.StudentId }
      );
    }

        private int id = 1;
        //TODO Get back to params

        // seedRoles(modelBuilder, roleName, create)
        // seedRoles(modelBuilder, roleName, create, update,delete)
        private void SeedRoles(ModelBuilder modelBuilder, string roleName, params string[] permissions)
        {
            var role = new IdentityRole {
                Id =roleName.ToLower(), 
                Name= roleName,
                NormalizedName = roleName.ToUpper(),
                ConcurrencyStamp = Guid.Empty.ToString()

            };
            modelBuilder.Entity<IdentityRole>().HasData(role);

            var RoleClaims = permissions.Select(permission =>
            new IdentityRoleClaim<string>
            {
                Id = id++,
                RoleId = role.Id,
                ClaimType = "permissions",
                ClaimValue = permission
            }
            ).ToArray();

            modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(RoleClaims);
        }
  }

}
