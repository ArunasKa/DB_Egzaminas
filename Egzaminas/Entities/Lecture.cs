
namespace Egzaminas.Entities
{
    public class Lecture
    {
        public Lecture(string name)
        {
            Name = name;
            Departments = new List<Department>();
            Students = new List<Student>();
        }

        public Guid Id { get; set; }    
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
        public List<Student> Students { get; set; }
    }
}
