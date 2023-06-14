using System;

using System.Collections.Generic;
namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attendedCourses = new List<string> { "Живопис", "Малюнок" };
            List<string> studentsThisYear = new List<string> { "Rembrant", "Repin","Picasso","Matis" };


            // Printing teacher  and course information
            Teacher teacherName = new Teacher("Leonard", "De Vinci", 45, "Milan", attendedCourses, studentsThisYear);
            teacherName.DescribeYourself();
            Console.WriteLine();

            

            // Creating a Course object

            Course course = new Course("Анатомія", "Leonard de Vinci", 40, 4, studentsThisYear);
            // Creating a Student object

            Student student = new Student("Vincent", "Van Gogh", 20, "Amsterdam", attendedCourses);

          
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
            studentsThisYear.Add("Van Gogh");
            Console.WriteLine("After adding a student to the course:");
            course.Print();
            
            // Deleting a course from the student
            student.DeleteCourse("Анатомія");
            Console.WriteLine("After deleting a course:");
            student.DescribeYourself();

  

        

        }
    }
}
