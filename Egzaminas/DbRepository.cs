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
            _context.Students.Add(student);
        }

        public void AddLecture(Lecture lecture)
        {
            _context.Lectures.Add(lecture); 
        }

        public Department GetDepartmentFromStudents(string departmentName)
        {
            return _context.Departments.Include(s => s.Students).FirstOrDefault(s => s.Name == departmentName);
        }

        public List<Lecture> GetAllLecturesForDepartment(string departmentName)
        {
            var department = GetDepartmentFromLectures(departmentName);
            var lectures = _context.Lectures.Where(s => s.Departments.All(d=>d.Id.Equals(department.Id))).ToList();
            return lectures;
        }

        public List<Student> GetAllStudentsForDepartment(string departmentName)
        {

            var department = GetDepartmentFromStudents( departmentName);
            var students = _context.Students.Where(s=>s.DepartmentId.Equals(department.Id)).ToList();
            return students;
        }
        public List<Lecture> GetAllLecturesForStudent(Guid studentId)
        {
            return _context.Lectures.Where(l => l.Students.All(d => d.Id.Equals(studentId))).ToList();
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

        public  void DeleteStudent(string studentName)
        {
            var student = GetStudent(studentName);
            _context.Students.Remove(student);
            //_context.Lectures.Select(l => l.Students.RemoveAll(s => s.Id.Equals(student.Id)));
        }

        public void UpdateDepartment(Department department)
        {
            _context.Update(department);
        }

        public void AssignLecturesToStudent(Student student, List<Lecture> lectures)
        {
            foreach (var lecture in lectures)
            {
                lecture.Students.Add(student ?? new Student(student.Name));
                UpdateLecture(lecture);
            }
                
                SaveChanges();
        }

        public void UpdateLecture(Lecture lecture)
        {
            _context.Update(lecture);
        }
        public void UpdateStudent(Student studentToUpdate)
        {
            _context.Update(studentToUpdate);
        }
    }
}
