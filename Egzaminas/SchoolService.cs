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
        public void AddStudentToDepartment(Guid departmentId, string studentName)
        {
            var department = _dbRepository.GetDepartment(departmentId);
            if (department.Students.Any(d=>d.Name.Equals(studentName, StringComparison.InvariantCultureIgnoreCase)))
            {
                return;
            }
            var studentFromDb = _dbRepository.GetStudent(studentName);
            department.Students.Add(studentFromDb ?? new Student(studentName));
            _dbRepository.UpdateDepartment(department);
            //_dbRepository.SaveChanges();


        }



    }
}
