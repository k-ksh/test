using System;
using System.Collections.Generic;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Student object
            List<string> attendedCourses = new List<string> { "Живопис", "Малюнок" };
           // List <string> presentedCourse= new List<string> { "Живопис", "Малюнок" };

            Student student = new Student("Vincent", "Van Gogh", 20, "Amsterdam", attendedCourses);

            // Creating a Course object
            Course course = new Course("Анатомія", "Leonard de Vinci", 40, 10);

            // Printing student and course information
            student.DescribeYourself();
            Console.WriteLine();
            course.Print();

            // Adding a course to the student
            student.AddCourse("Анатомія");
            Console.WriteLine("After adding a course:");
            student.DescribeYourself();


            // Adding a student to the course
            course.AddStudent();
            Console.WriteLine("After adding a student to the course:");
            course.Print();


            // Deleting a course from the student
            student.DeleteCourse("Анатомія");
            Console.WriteLine("After deleting a course:");
            student.DescribeYourself();

            // Printing teacher  and course information
            Teacher teacher = new Teacher("Leonard", "De Vinci", 45, "Milan", "Анатомія");
            teacher.DescribeYourself();
            //Console.WriteLine();

        

        }
    }
}
