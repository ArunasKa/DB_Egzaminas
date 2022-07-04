
namespace Egzaminas.Entities
{
    public class Student
    {
        public Student(string name)
        {
            Name = name;
            Lectures = new List<Lecture>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Lecture> Lectures { get; set; }
        public Guid? DepartmentId { get; set; }
    }
}
