using System.Xml.Linq;

namespace MyNamespace
{
    class Teacher:Person
    {
        public List<string> StudentsThisYear { get; set; }
        public Teacher(string firstName, string lastName, int age, string city, List<string> coursesAttended,List<string> studentsThisYear) : base(firstName,lastName,age,city, coursesAttended)
        {
            StudentsThisYear = studentsThisYear;
        }

     public override void DescribeYourself()
        {
            base.DescribeYourself();

            // Console.WriteLine($"Courses Presented: {CoursesAttended}");

            Console.WriteLine("Courses Presented:");
            foreach (var course in CoursesAttended)
            {
                Console.WriteLine(course);
            }
        }
   
        



    }
}
