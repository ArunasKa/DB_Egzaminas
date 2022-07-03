using Egzaminas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Egzaminas
{
    public class SchoolDbContext : DbContext
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=(localdb)\\mssqllocaldb;Database=StudentsDB;Trusted_Connection=True;");

        }
    }
}
