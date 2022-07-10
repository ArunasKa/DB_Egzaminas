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

                        var departmentName = GetStringInput("(Create)Department Name ");
                        schoolService.CreateDepartment(departmentName);
                        schoolService.AddStudentToDepartment(departmentName, GetStringInput("Student Name"));
                        schoolService.AddLectureToDepartment(departmentName, GetStringInput("Lecture Name"));
                        break;
                    case 2:
                        schoolService.AddStudentToDepartment(GetStringInput("Department Name"), GetStringInput("Student Name"));

                        break;
                    case 3:
                        schoolService.AddLectureToDepartment(GetStringInput("Department Name"), GetStringInput("Lecture Name"));

                        break;
                    case 4:
                        var studentName4 = GetStringInput("Student Name");
                        var departmentName4 = GetStringInput("Department Name");
                        schoolService.AddStudent(studentName4);
                        schoolService.AssignStudentToDepartment(studentName4, departmentName4);
                        schoolService.AssignLectturesToStudentFromDepartment(studentName4, departmentName4);

                        break;
                    case 5:
                        var studentName5 = GetStringInput("Student Name");
                        var DepartmentName5 = GetStringInput("Department Name");
                        schoolService.MoveStudentToDepartment(studentName5, DepartmentName5);
                        schoolService.AssignLectturesToStudentFromDepartment(studentName5, DepartmentName5);

                        break;
                    case 6:
                        schoolService.ShowAllStudentsForDepartment(GetStringInput("Department Name"));

                        break;
                    case 7:
                        schoolService.ShowAllLecturesForDepartment(GetStringInput("Department Name"));

                        break;
                    case 8:
                        schoolService.ShowAllLecturesForStudent(Guid.Parse("6638C1D3-1097-4502-BC62-08DA5EA82164"));

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
        private string GetStringInput(string text)
        {
            Console.Write($"{text}:");
            return Console.ReadLine();
        }
    }
}
