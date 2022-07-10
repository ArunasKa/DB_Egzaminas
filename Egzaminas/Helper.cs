

using Egzaminas.Entities;

namespace Egzaminas
{
    public  static  class Helper
    {

        public static  string GetStringInput(string text)
        {
            Console.Write($"{text}:");
            return Console.ReadLine();
        }

        public static void PrintOutLectureList(List<Lecture> lectures)
        {
            foreach (var lecture in lectures)
            {
                Console.WriteLine(lecture.Name);
            }
        }
        public static void PrintOutStudentsList(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
