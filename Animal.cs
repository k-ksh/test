using MyNamespace;
using System.Collections.Generic;
using System.Xml.Linq;
namespace MyNamespace
{
    class Animal
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public double Lenght { get; private set; }
        public string Sound { get; private set; }
        public int Tail{ get; private set; }


        public Animal(string name,string color, double lenght,string sound, int tail)
            {

            Name = name;
            Color = color;
            Lenght = lenght;
            Sound = sound;
            Tail = tail;

            }
        public virtual void MakeSound()
        {

        }


    }
}
