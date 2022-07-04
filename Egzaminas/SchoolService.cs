using Egzaminas.Entities;

namespace Egzaminas
{
    public class SchoolService
    {
        private readonly DbRepository _dbRepository;

        public SchoolService()
        {
            _dbRepository = new DbRepository();
        }

        public void CreateDepartment(string name)
        {
            var department = new Department(name);
            _dbRepository.AddDepartment(department);
            _dbRepository.SaveChanges();
        }
        public void CreateLecture(string name)
        {
            var lecture = new Lecture(name);
            _dbRepository.AddLecture(lecture);
            _dbRepository.SaveChanges();
        }

        public void ShowAllLecturesForDepartment(string departmentName)
        {
            var lectures = _dbRepository.GetAllLecturesForDepartment(departmentName);
            foreach (var lecture in lectures)
            {
                //Console.WriteLine($"{student.Id} {student.Name} {student.DepartmentId}");
                Console.WriteLine(lecture.Name);
            }
        }

        public void ShowAllStudentsForDepartment(string departmentName)
        {
            var Students = _dbRepository.GetAllStudentsForDepartment(departmentName);
            foreach (var student in Students)
            {
                //Console.WriteLine($"{student.Id} {student.Name} {student.DepartmentId}");
                Console.WriteLine(student.Name);
            }
        }

        public void CreateStudent( string studentName)
        {
            var student = new Student(studentName);
            _dbRepository.AddStudent(student);
            _dbRepository.SaveChanges();
        }
        public void AddStudentToDepartment(string departmentName, string studentName)
        {
            var department = _dbRepository.GetDepartmentFromStudents(departmentName);
            
            if ( department.Students.Any(d=>d.Name.Equals(studentName, StringComparison.InvariantCultureIgnoreCase)))
            {
                Console.WriteLine("Found item");
                var studentToUpdate = _dbRepository.GetStudent(studentName);
                studentToUpdate.DepartmentId = department.Id;
                _dbRepository.UpdateStudent(studentToUpdate);
                _dbRepository.SaveChanges();
                return;
            }
            var studentToAdd = _dbRepository.GetStudent(studentName);
            department.Students.Add(studentToAdd ?? new Student(studentName));
            _dbRepository.UpdateDepartment(department);
            _dbRepository.SaveChanges();
        }
        public void AddLectureToDepartment(string departmentName, string lectureName)
        {
            var department = _dbRepository.GetDepartmentFromLectures(departmentName);
            //if (department.Lectures.Any(d => d.Name.Equals(lectureName)))
            if(department is null)
            {
                Console.Write("No such department, Enter name: ");
                var tempDepartmentName = Console.ReadLine();
                CreateDepartment(departmentName);
                department = _dbRepository.GetDepartmentFromLectures(departmentName);
                
            }
            var lectureFromDb = _dbRepository.GetLecture(lectureName);
            department.Lectures.Add(lectureFromDb ?? new Lecture(lectureName));
            _dbRepository.UpdateDepartment(department);
            _dbRepository.SaveChanges();
        }
        public void AddStudentToLecture(string studentName, Guid studentId, string lectureName)
        {
            var lecture = _dbRepository.GetLectureFromStudents(lectureName);
            if (lecture.Students.Any(s=>s.Id.Equals(studentId)))
            {
                return;
            }
            var studenttFromDb = _dbRepository.GetStudent(studentId);
            lecture.Students.Add(studenttFromDb ?? new Student(studentName));
            _dbRepository.UpdateLecture(lecture);
            _dbRepository.SaveChanges();
        }


    }
}
