using System.Xml.Linq;

namespace MyNamespace
{
    class Teacher:Person
    {
        public List<string> StudentsThisYear { get; set; }
        public List<string> CoursesPresented { get; set; }

        public Teacher(string firstName, string lastName, int age, string city, List<string> coursesPresented,List<string> studentsThisYear) : base(firstName,lastName,age,city)
        {
            StudentsThisYear = studentsThisYear;
            CoursesPresented = coursesPresented;
        }

     public override void DescribeYourself()
        {
            base.DescribeYourself();


            Console.WriteLine("Courses Presented:");
            foreach (var course in CoursesPresented)
            {
                Console.WriteLine(course);
            }
        }

        public void AddCourse(string course)
        {
            CoursesPresented.Add(course);
        }


        public void DeleteCourse(string course)
        {
            CoursesPresented.Remove(course);
        }

    }
}
