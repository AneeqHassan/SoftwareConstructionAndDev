using Microsoft.EntityFrameworkCore;
using SchoolProject.Models.Entities;

namespace SchoolProject.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
       
    }
}
