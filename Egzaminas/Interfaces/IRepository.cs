using Egzaminas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzaminas.Interfaces
{
    public interface IRepository
    {

        void AddDepartment(Department department);
        void SaveChanges();
        void AddStudent(Student student);
        void AddLecture(Lecture lecture);
        Department GetDepartmentFromStudents(string departmentName);
        List<Lecture> GetAllLecturesForDepartment(string departmentName);
        Department GetDepartment(string departmentName);
        List<Student> GetAllStudentsForDepartment(string departmentName);
        List<Lecture> GetAllLecturesForStudent(Guid studentId);
        Lecture GetLectureFromStudents(string lectureName);
        Department GetDepartmentFromLectures(string departmentName);
        Student GetStudent(string studentName);
        Student GetStudent(Guid studentId);
        void AssignDepartmentToStudent(string studentName, string departmentName);
        Lecture GetLecture(string lectureName);
        void DeleteStudent(string studentName);
        void UpdateDepartment(Department department);
        void AssignLecturesToStudent(Student student, List<Lecture> lectures);
        void UpdateLecture(Lecture lecture);
        void UpdateStudent(Student studentToUpdate);
    }
}
