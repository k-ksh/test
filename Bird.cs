using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
     class Bird : Animal
    {
        public int TailLength;
        public Bird(int tailLength, string name, string color, double lenght, string sound) : base(name, color, lenght, sound)

        {
            TailLength = tailLength;
        }

        public virtual void Fly()

        {
            Console.WriteLine($"this bird {Name} flies with tail length {TailLength} ");
        }
    }
}
