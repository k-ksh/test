using System.Xml.Linq;
using System.Collections.Generic;

namespace MyNamespace
{
    class Dog:Animal
    {

        public Dog(string name, string color, double lenght, string sound, int tail):base(name, color, lenght, sound, tail)
        {
           
        }

        public override void MakeSound()
        {

            Console.WriteLine($"This dog {Name} makes the sound: hav hav2");
        }
    }
}
