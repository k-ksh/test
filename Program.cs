using System;

using System.Collections.Generic;
namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attendedCourses = new List<string> { "Живопис", "Малюнок" };
            List<string> coursesPresented = new List<string> { "Koмпозиція", "Живопис", "Малюнок" };
            List<string> studentsThisYear = new List<string> { "Rembrant", "Repin","Picasso","Matis" };
            List<string> teacher = new List<string> { "prof1" };

            
            // Creating a teacher  and course information
            Teacher teacherName1 = new Teacher("Leonard", "De Vinci", 45, "Milan", coursesPresented, studentsThisYear);
            Teacher teacherName2 = new Teacher("Sandro", "Bottichelli", 32, "Florence", coursesPresented, studentsThisYear);
            Teacher teacherName3 = new Teacher("prof1", "prof1", 50, "Paris", attendedCourses, studentsThisYear);
            Console.WriteLine("Teacher:");
            teacherName1.DescribeYourself();
            teacherName2.DescribeYourself();
            teacherName3.DescribeYourself();
            Console.WriteLine();
            teacher.Add("Leonard De Vinci");
            teacher.Add("Sandro Bottichelli");


            // Creating a Student object
            Student student = new Student("Vincent", "Van Gogh", 20, "Amsterdam", attendedCourses);


            // Creating a Course object
            Course course = new Course("Анатомія", "Leonard de Vinci", 40, 4, studentsThisYear, teacher);


            // Adding a course to the teacher 
            teacherName1.AddCourse("Анатомія");
            Console.WriteLine("After adding a course:");
            teacherName1.DescribeYourself();

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

            // Displaying all students with their courses
            Console.WriteLine("All Students:");

            foreach (var stud in studentsThisYear)
               
            {
                Console.WriteLine("Student " + stud +" is attending courses:");
             

                foreach (var cours in attendedCourses)

                {
                    Console.WriteLine(cours);


                }
            }

            //Displaying all teachers with their courses
            Console.WriteLine("All Teachers:");
            foreach (var teach in teacher)

            {
                Console.WriteLine("Teacher " + teach + " is presenting courses:");


                foreach (var cours in coursesPresented)

                {
                    Console.WriteLine(cours);


                }
            }

            //Displaying all courses
            //with their teacher and students - displaying all courses
            //(for each course, display the teacher and all students)
            Console.WriteLine("All Courses:");

            foreach (var cours in coursesPresented)

            {
                Console.WriteLine("Course " + cours);


                foreach (var teach in teacher)

                {
                    Console.WriteLine(" is presenting by teacher:"+teach);
                    Console.WriteLine("For students:");
                    foreach (var stud in studentsThisYear)

                    {
                        Console.WriteLine(stud);
                    }

                }
            }
          

        }
    }
}
