using System.Data.Entity;

using StudentSystem.Models;

namespace StudentSystem.Data
{
    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext() : base("StudentSystemDb")
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Homework> Homeworks { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}
