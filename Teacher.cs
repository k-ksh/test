using System.Xml.Linq;

namespace MyNamespace
{
    class Teacher:Person
    {
        public List<Student> Student { get; set; }
        public List<Course> Course { get; set; }
        public int TeacherId { get; set; }

        public Teacher(int teacherId, string firstName, string lastName, int age, string city, List<Course> course, List<Student> student) : base(firstName,lastName,age,city)
        {
            Student = student;
            Course = course;
            TeacherId = teacherId;
        }

     public override void DescribeYourself()
        {
            base.DescribeYourself();


            Console.WriteLine("Courses Presented:");
            foreach (var course in Course)
            {
                Console.WriteLine($"ID: {course.CourseId}");
                Console.WriteLine($"Name: {course.CourseName}");
                // Retrieve other properties as needed
                Console.WriteLine();

                Console.WriteLine("Courses Taught:");
                var commonCourses = Student.SelectMany(s => s.Course).Distinct().Intersect(Student.SelectMany(s => s.Course).Distinct());
                foreach (var subj in commonCourses)
                {
                    Console.WriteLine($"- {subj.CourseName} (Student: {string.Join(", ", course.Student.Select(s => s.FirstName + " " + s.LastName))})");
                }

                //(Students: {string.Join(", ", course.Students.Select(s => s.FirstName + " " + s.LastName))})");
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
