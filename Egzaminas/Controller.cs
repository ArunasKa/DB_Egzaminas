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
                    "8 Atvaizduoti visas paskaitas pagal studentą.\n");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        schoolService.CreateDepartment(GetStringInput("(Create)Department Name "));
                        Console.WriteLine("Add student to department");
                        schoolService.AddStudentToDepartment(GetStringInput("Department Name"), GetStringInput("Student Name"));
                        Console.WriteLine("Add lecture to department");
                        schoolService.AddLectureToDepartment(GetStringInput("Department Name"), GetStringInput("Lecture Name"));
                        break;
                    case 2:
                        schoolService.AddStudentToDepartment(GetStringInput("Department Name"), GetStringInput("Student Name"));

                        break;
                    case 3:
                        schoolService.AddLectureToDepartment(GetStringInput("Department Name"), GetStringInput("Lecture Name"));

                        break;
                    case 4:
                        schoolService.AddStudentToDepartment(GetStringInput("Department Name"), GetStringInput("Student Name"));

                        break;
                    case 5:
                        schoolService.AddStudentToDepartment(GetStringInput("Department Name"), GetStringInput("Student Name")); // assing department to student

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
