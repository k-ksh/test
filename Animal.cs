using MyNamespace;
using System.Collections.Generic;
using System.Xml.Linq;
namespace MyNamespace
{
    class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Lenght { get; set; }
        public string Sound { get; set; }

        public Animal(string name,string color, double lenght,string sound)
            {

            Name = name;
            Color = color;
            Lenght = lenght;
            Sound = sound;
      
            }
        public virtual void MakeSound()
        {
           
            Console.WriteLine($"this animal {Name} makes sound {Sound} ");
        }


        public virtual void DescribeYourself()
        {
            Console.WriteLine($" this animal {Name} has color {Color}");

            Console.WriteLine();

           }


        }
}
