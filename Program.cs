using System;


using System.Collections.Generic;

using System.Xml.Linq;

namespace MyNamespace
{
    class Program
    {
        public int NumberOfStudents { get; set; }
        static void Main(string[] args)
        {

            List<Course> course = new List<Course>();
            List<Student> student = new List<Student>();
            List<Teacher> teacher = new List<Teacher>();

            Course courseName1 = new Course(1, "Koмпозиція", "Leonardo", 180,student,teacher);

            course.Add(courseName1);

        // Creating a student  and course information
            Student studentName1 = new Student(1, "Rembrant", "R", 13, "Milan", course);
            Student studentName2 = new Student(2, "Repin", "Re", 15, "Milan", course);
            student.Add(studentName1);


            //List<string> student = new List<Student>()
            //{ new Student() { StudentId = 1,FirstName ="Rembrant",LastName ="R", Age = 13,City="Milan" } ,
            //    new Student() { StudentId = 2, FirstName ="Repin",LastName ="Re", Age = 21,City="Milan" } ,
            //    new Student() { StudentId = 3, FirstName ="Picasso",LastName ="Pablo", Age = 18,City="Milan" } ,
            //    new Student() { StudentId = 4, FirstName ="Matis",LastName ="Ma", Age = 20,City="Milan"}
            //};


            
            // Creating a teacher  and course information
            Teacher teacherName1 = new Teacher(1,"Leonard", "De Vinci", 45, "Milan", course, student);
            Teacher teacherName2 = new Teacher(2,"Sandro", "Bottichelli", 32, "Florence", course, student);
            Teacher teacherName3 = new Teacher(3,"prof1", "prof1", 50, "Paris", course, student);
            //Console.WriteLine("Teacher:");
            //teacherName1.DescribeYourself();
            //teacherName2.DescribeYourself();
            //teacherName3.DescribeYourself();
            //Console.WriteLine();
            teacher.Add(teacherName1);
            teacher.Add(teacherName2);
            teacher.Add(teacherName3);

            // Creating a Course object
            Course courseName2 = new Course(2,"Анатомія", "Leonard de Vinci", 40,  student, teacher);
          
            Course courseName3 = new Course(3, "Живопис", "Botticheli", 40, student, teacher);
          

            // Adding a course to the teacher 
            teacherName1.AddCourse(courseName2);
            teacherName2.AddCourse(courseName3);
            Console.WriteLine("After adding a course to the teacher:");
            teacherName1.DescribeYourself();
            teacherName2.DescribeYourself();
            // Printing student and course information
            studentName1.DescribeYourself();
            Console.WriteLine();

            
           // courseName2.Print();            

            // Adding a course to the student
            studentName2.AddCourse(courseName3);
            Console.WriteLine("After adding a course to the student:");
            studentName2.DescribeYourself();


            // Adding a student to the course
            courseName3.AddStudent(studentName2);
         
            Console.WriteLine("After adding a student to the course:");
            courseName3.Print();
            teacherName1.DescribeYourself();
            teacherName2.DescribeYourself();

            // Deleting a course from the student
            studentName1.DeleteCourse(courseName2);
            Console.WriteLine("After deleting a course:");
            studentName1.DescribeYourself();

            //// Displaying all students with their courses
            //Console.WriteLine("All Students:");

            //foreach (var stud in studentsThisYear)
               
            //{
            //    Console.WriteLine("Student " + stud +" is attending courses:");
             

            //    foreach (var cours in attendedCourses)

            //    {
            //        Console.WriteLine(cours);


            //    }
            //}

            ////Displaying all teachers with their courses
            //Console.WriteLine("All Teachers:");
            //foreach (var teach in teacher)

            //{
            //    Console.WriteLine("Teacher " + teach + " is presenting courses:");


            //    foreach (var cours in coursesPresented)

            //    {
            //        Console.WriteLine(cours);


            //    }
            //}

            ////Displaying all courses
            ////with their teacher and students - displaying all courses
            ////(for each course, display the teacher and all students)
            //Console.WriteLine("All Courses:");

            //foreach (var cours in coursesPresented)

            //{
            //    Console.WriteLine("Course " + cours);


            //    foreach (var teach in teacher)

            //    {
            //        Console.WriteLine(" is presenting by teacher:"+teach);
            //        Console.WriteLine("For students:");
            //        foreach (var stud in studentsThisYear)

            //        {
            //            Console.WriteLine(stud);
            //        }

            //    }
            //}
          

        }
    }
}
