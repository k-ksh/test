﻿using MyNamespace;
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
      


        public Person(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
           
        }

        public virtual void DescribeYourself()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine();

        }


    }
}
