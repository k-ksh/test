using System.Xml.Linq;

namespace MyNamespace
{
    class Teacher:Person
    {
        public string CoursesAttended { get; set; }
        public Teacher(string firstName, string lastName, int age, string city, string coursesAttended) : base(firstName,lastName,age,city)
        {

            CoursesAttended = coursesAttended;
        }

      
     public override void DescribeYourself()
        {
            base.DescribeYourself();
           
            Console.WriteLine($"Courses Presented: {CoursesAttended}");
        }
   
        



    }
}
