using MyNamespace;
using System.Collections.Generic;
using System.Xml.Linq;
namespace MyNamespace
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public List<string> CoursesAttended { get; set; }
      

        public Person(string firstName, string lastName, int age, string city, List<string> coursesAttended)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            CoursesAttended = coursesAttended;
        }

        public virtual void DescribeYourself()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"City: {City}");
           
        }


    }
}
