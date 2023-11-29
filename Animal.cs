using MyNamespace;
using System.Collections.Generic;
using System.Xml.Linq;
namespace MyNamespace
{
    class Animal
    {
        public string Name { get; protected set; }
        public string Color { get; protected set; }
        public double Lenght { get; protected set; }
      
        


        public Animal(string name,string color, double lenght)
            {

            Name = name;
            Color = color;
            Lenght = lenght;
            

            }
        public virtual void MakeSound()
        {

        }

    }
}
