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

        public Department GetDepartmentFromStudents(Guid departmentId)
        {
            return _context.Departments.Include(s => s.Students).FirstOrDefault(s => s.Id == departmentId);
        }
        public Lecture GetLectureFromStudents(string lectureName)
        {
            return _context.Lectures.Include(s => s.Students).FirstOrDefault(s => s.Name == lectureName);
        }
        public Department GetDepartmentFromLectures(string departmentName)
        {
            return _context.Departments.Include(s => s.Lectures).FirstOrDefault(s => s.Name == departmentName);
        }

        public Student GetStudent(string studentName)
        {
            return _context.Students.FirstOrDefault(s => s.Name.ToUpper() == studentName.ToUpper());
        }
        public Student GetStudent(Guid studentId)
        {
            return _context.Students.FirstOrDefault(s => s.Id == studentId);
        }
        public Lecture GetLecture(string lectureName)
        {
            return _context.Lectures.FirstOrDefault(s => s.Name.ToUpper() == lectureName.ToUpper());
        }

        public void UpdateDepartment(Department department)
        {
            _context.Update(department);
        }
        public void UpdateLecture(Lecture lecture)
        {
            _context.Update(lecture);
        }
    }
}
