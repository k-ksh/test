
using System.Collections.Generic;
namespace MyNamespace
{
    class Course
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int CourseDuration { get; set; }
        //public int NumberOfStudents { get; set; }
        public int NumberOfStudents { get; private set; }
        public List<Student> Student { get; set; }
        public List<Teacher> Teacher { get; set; }
  
        public int CourseId { get; set; }
        public Course(int courseId,string courseName, string teacherName, int courseDuration,  List<Student> student, List<Teacher> teacher)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            CourseDuration = courseDuration;
            CourseId=courseId;
            
            Student = student;
            Teacher = teacher;
            NumberOfStudents = student.Count;
        }

        
        public void Print()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Teacher: {TeacherName}");
            Console.WriteLine($"Duration: {CourseDuration} hours");
            Console.WriteLine($"Number of Students: {NumberOfStudents}");
            Console.WriteLine($"Students this year:");

            foreach (var stud in Student)
                {
                    Console.WriteLine($"ID: {stud.StudentId}");
                    Console.WriteLine($"Name: {stud.FirstName} {stud.LastName}");
                    // Retrieve other properties as needed
                    Console.WriteLine();
                }
            
        }

        public void AddStudent(Student student)
        {
            Student.Add(student);
            NumberOfStudents++;
        }


    }

}
