using Egzaminas.Entities;
using Microsoft.EntityFrameworkCore;


namespace Egzaminas
{
    public class DbRepository
    {
        private readonly SchoolDbContext _context;

        public DbRepository()
        {
            _context = new SchoolDbContext();
        }

        public void AddDepartment(Department department)
        {
            _context.Departments.Add(department);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartment(Guid studentID)
        {
            return _context.Departments.Include(s => s.Students).FirstOrDefault(s => s.Id == studentID);
        }

        public Student GetStudent(string studentName)
        {
            return _context.Students.FirstOrDefault(s => s.Name.ToUpper() == studentName.ToUpper());
        }

        internal void UpdateDepartment(Department department)
        {
            _context.Update(department);
        }
    }
}
