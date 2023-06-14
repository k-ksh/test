
using System.Collections.Generic;
namespace MyNamespace
{
    class Course
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int CourseDuration { get; set; }
        public int NumberOfStudents { get; set; }
        public List<string> StudentsThisYear  { get; set; }


        public Course(string courseName, string teacherName, int courseDuration, int numberOfStudents, List<string> studentsThisYear)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            CourseDuration = courseDuration;
            NumberOfStudents = numberOfStudents;
            StudentsThisYear = studentsThisYear;
           

        }

        public void Print()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Teacher: {TeacherName}");
            Console.WriteLine($"Duration: {CourseDuration} hours");
            Console.WriteLine($"Number of Students: {NumberOfStudents}");
            Console.WriteLine($"Students this year:");
            foreach (var stud in StudentsThisYear)
            {
                Console.WriteLine(stud);
            }
        }

        public void AddStudent()
        {
            NumberOfStudents++;
  
        }


    }

}
