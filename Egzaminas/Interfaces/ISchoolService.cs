using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzaminas.Interfaces
{
    public interface ISchoolService
    {
        void CreateDepartment(string name);
        void AddStudent(string studentName);
        void ShowAllLecturesForDepartment(string departmentName);
        void ShowAllStudentsForDepartment(string departmentName);
        void ShowAllLecturesForStudent(Guid studentId);
        void AddStudentToDepartment(string departmentName, string studentName);
        void AssignStudentToDepartment(string studentName, string departmentName);
        void MoveStudentToDepartment(string studentName, string DepartmentName);
        void AssignLectturesToStudentFromDepartment(string studentName, string departmentName);
        void AddLectureToDepartment(string departmentName, string lectureName);




    }
}
