using System.Xml.Linq;
using System.Collections.Generic;

namespace MyNamespace
{
    class Student:Person
    {
        public List<Course> Course { get; set; }
        
        public int StudentId { get; set; }
    

        public Student(int studentId, string firstName, string lastName, int age, string city, List<Course> course) : base(firstName,lastName,age,city)
        {
            StudentId = studentId;
            Course = course;
           
        }

        public override void DescribeYourself()
        {
            base.DescribeYourself();
            Console.WriteLine("Role: Student");
            Console.WriteLine("Courses Attended:");
            foreach (var course in Course)
            {
                Console.WriteLine($"ID: {course.CourseId}");
                Console.WriteLine($"Name: {course.CourseName}");
                // Retrieve other properties as needed
                Console.WriteLine();


            }
        }

        public void AddCourse(Course course)
        {
            Course.Add(course);
        }


        public void DeleteCourse(Course course)
        {
            Course.Remove(course);
        }
    }
}
