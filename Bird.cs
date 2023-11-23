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
        public int Tail { get; protected set; }
        public Bird(string name, string color, double lenght, string sound, int tail) : base(name, color, lenght, sound)

        {
            Tail = tail;
        }

        public override void MakeSound()
        {

            Console.WriteLine($"This bird {Name} makes the sound: piu piu");
        }
        public virtual void Fly()

        {
            Console.WriteLine($"this bird {Name} flies with tail length {Tail} ");
        }
    }
}
