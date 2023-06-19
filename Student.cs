using System.Xml.Linq;
using System.Collections.Generic;

namespace MyNamespace
{
    class Student:Person
    {
        public List<string> CoursesAttended { get; set; }
        public Student(string firstName, string lastName, int age, string city, List<string> coursesAttended) : base(firstName,lastName,age,city)
        {
            CoursesAttended = coursesAttended;
        }
        public override void DescribeYourself()
        {
            base.DescribeYourself();
            Console.WriteLine("Role: Student");
            Console.WriteLine("Courses Attended:");
            foreach (var course in CoursesAttended)
            {
                Console.WriteLine(course);
            }
        }

        public void AddCourse(string course)
        {
            CoursesAttended.Add(course);
        }


        public void DeleteCourse(string course)
        {
            CoursesAttended.Remove(course);
        }
    }
}
