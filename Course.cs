namespace MyNamespace
{
    class Course
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int CourseDuration { get; set; }
        public int NumberOfStudents { get; set; }

        public Course(string courseName, string teacherName, int courseDuration, int numberOfStudents)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            CourseDuration = courseDuration;
            NumberOfStudents = numberOfStudents;
        }

        public void Print()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Teacher: {TeacherName}");
            Console.WriteLine($"Duration: {CourseDuration} hours");
            Console.WriteLine($"Number of Students: {NumberOfStudents}");
        }

        public void AddStudent()
        {
            NumberOfStudents++;
        }


    }

}
