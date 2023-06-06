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
            Student student = new Student("Vincent", "Van Gogh", 20, "Amsterdam", attendedCourses);

            // Creating a Course object
            Course course = new Course("Анатомія", "Leonard de Vinci", 40, 10);

            // Printing student and course information
            student.Print();
            Console.WriteLine();
            course.Print();

            // Adding a course to the student
            student.AddCourse("Анатомія");
            Console.WriteLine("\nAfter adding a course:");
            student.Print();


            // Adding a student to the course
            course.AddStudent();
            Console.WriteLine("\nAfter adding a student to the course:");
            course.Print();


            // Deleting a course from the student
            student.DeleteCourse("Анатомія");
            Console.WriteLine("\nAfter deleting a course:");
            student.Print();
        }
    }
}
