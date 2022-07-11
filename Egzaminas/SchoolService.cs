using Egzaminas.Entities;
using Egzaminas.Interfaces;

namespace Egzaminas
{
    public class SchoolService : ISchoolService
    {
        private readonly DbRepository _dbRepository;

        public SchoolService()
        {
            _dbRepository = new DbRepository();
            //_dbRepository.AddLecture(new Lecture("Lecture_Name_1"));
            //_dbRepository.AddDepartment(new Department("Department_Name_1"));
            //_dbRepository.AddStudent(new Student("Student_Name_1"));
            //_dbRepository.SaveChanges();
        }

        public void CreateDepartment(string name)
        {
            var department = new Department(name);
            _dbRepository.AddDepartment(department);
            _dbRepository.SaveChanges();
        }
        public void AddStudent(string studentName)
        {
            _dbRepository.AddStudent(new Student(studentName));
            _dbRepository.SaveChanges();

        }
        public void ShowAllLecturesForDepartment(string departmentName)
        {
            var lectures = _dbRepository.GetAllLecturesForDepartment(departmentName);
            Helper.PrintOutLectureList(lectures);
        }
        public void ShowAllStudentsForDepartment(string departmentName)
        {
            var students = _dbRepository.GetAllStudentsForDepartment(departmentName);
            Helper.PrintOutStudentsList(students);
        }
        public void ShowAllLecturesForStudent(Guid studentId)
        {
            var lectures = _dbRepository.GetAllLecturesForStudent(studentId);

            Helper.PrintOutLectureList(lectures);

        }
        public void AddStudentToDepartment(string departmentName, string studentName)
        {
            var department = _dbRepository.GetDepartment(departmentName);
            if ( department.Students.Any(d=>d.Name.Equals(studentName, StringComparison.InvariantCultureIgnoreCase)))
            {
                var studentToUpdate = _dbRepository.GetStudent(studentName);
                studentToUpdate.DepartmentId = department.Id;
                _dbRepository.UpdateStudent(studentToUpdate);
                _dbRepository.SaveChanges();
                return;
            }
            else
            {
                var studentToAdd = _dbRepository.GetStudent(studentName);
                department.Students.Add(studentToAdd ?? new Student(studentName));
                _dbRepository.UpdateDepartment(department);
                _dbRepository.SaveChanges();
            }
            
        }

        public void AssignStudentToDepartment(string studentName, string departmentName)
        {
            _dbRepository.AssignDepartmentToStudent(studentName, departmentName);
        }

        public void MoveStudentToDepartment( string studentName, string DepartmentName)
        {
            _dbRepository.DeleteStudent(studentName);
            AddStudentToDepartment(DepartmentName, studentName);
        }
        public void AssignLectturesToStudentFromDepartment(string studentName, string departmentName)
        {
            var student = _dbRepository.GetStudent(studentName);
            var lectures = _dbRepository.GetAllLecturesForDepartment(departmentName);
            _dbRepository.AssignLecturesToStudent(student, lectures);
        }
        public void AddLectureToDepartment(string departmentName, string lectureName)
        {
            var department = _dbRepository.GetDepartmentFromLectures(departmentName);
            if(department is null)
            {
                
                var tempDepartmentName = Helper.GetStringInput("No such department, Enter name: ");
                CreateDepartment(departmentName);
                department = _dbRepository.GetDepartmentFromLectures(departmentName);
                
            }
            var lectureFromDb = _dbRepository.GetLecture(lectureName);
            department.Lectures.Add(lectureFromDb ?? new Lecture(lectureName));
            _dbRepository.UpdateDepartment(department);
            _dbRepository.SaveChanges();
        }
      

    }
}
