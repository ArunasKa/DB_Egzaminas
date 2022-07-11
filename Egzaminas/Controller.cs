using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzaminas
{
    internal class Controller
    {
        public Controller()
        {
            Menu();
            
        }
        private void Menu()
        {

            var schoolService = new SchoolService();
            while (true)
            {
                Console.WriteLine("" +
                    "1 Sukurti departamentą ir į jį pridėti studentus, paskaitas(papildomi points jei pridedamos paskaitos jau egzistuojančios duomenų bazėje).\n" +
                    "2 Pridėti studentus/paskaitas į jau egzistuojantį departamentą.\n" +
                    "3 Sukurti paskaitą ir ją priskirti prie departamento.\n" +
                    "4 Sukurti studentą, jį pridėti prie egzistuojančio departamento ir priskirti jam egzistuojančias paskaitas.\n" +
                    "5 Perkelti studentą į kitą departamentą(bonus points jei pakeičiamos ir jo paskaitos).\n" +
                    "6 Atvaizduoti visus departamento studentus.\n" +
                    "7 Atvaizduoti visas departamento paskaitas.\n" +
                    "8 Atvaizduoti visas paskaitas pagal studentą.\n" +
                    "9 Exit");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:

                        var departmentName = Helper.GetStringInput("(Create)Department Name ");
                        schoolService.CreateDepartment(departmentName);
                        schoolService.AddStudentToDepartment(departmentName, Helper.GetStringInput("Student Name"));
                        schoolService.AddLectureToDepartment(departmentName, Helper.GetStringInput("Lecture Name"));
                        break;
                    case 2:
                        var DepartmentName2 = Helper.GetStringInput("Department Name");
                        schoolService.AddStudentToDepartment(DepartmentName2, Helper.GetStringInput("Student Name"));
                        schoolService.AddLectureToDepartment(DepartmentName2, Helper.GetStringInput("Lecture Name"));

                        break;
                    case 3:
                        schoolService.AddLectureToDepartment(Helper.GetStringInput("Department Name"), Helper.GetStringInput("Lecture Name"));

                        break;
                    case 4:
                        var studentName4 = Helper.GetStringInput("Student Name");
                        var departmentName4 = Helper.GetStringInput("Department Name");
                        schoolService.AddStudent(studentName4);
                        schoolService.AssignStudentToDepartment(studentName4, departmentName4);
                        schoolService.AssignLectturesToStudentFromDepartment(studentName4, departmentName4);

                        break;
                    case 5:
                        var studentName5 = Helper.GetStringInput("Student Name");
                        var DepartmentName5 = Helper.GetStringInput("Department Name");
                        schoolService.MoveStudentToDepartment(studentName5, DepartmentName5);
                        schoolService.AssignLectturesToStudentFromDepartment(studentName5, DepartmentName5);

                        break;
                    case 6:
                        schoolService.ShowAllStudentsForDepartment(Helper.GetStringInput("Department Name"));

                        break;
                    case 7:
                        schoolService.ShowAllLecturesForDepartment(Helper.GetStringInput("Department Name"));

                        break;
                    case 8:
                        schoolService.ShowAllLecturesForStudent(Guid.Parse(Helper.GetStringInput("Student Id ")));

                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No such option");
                        break;
                }
            }
            
        }
        
    }
}
