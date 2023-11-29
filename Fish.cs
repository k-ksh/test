using System.Drawing;
using System.Xml.Linq;

namespace MyNamespace
{
    class Fish:Animal
    {
        public int depth;
        public Fish(int depth, string name, string color, double lenght):base(name, color, lenght)
        {
            depth = 0;
        }

        public void Dive(int newDepth)
        {
            if (newDepth < 0)
            {
                Console.WriteLine("Depth cannot be negative.");
            }
            else
            {
                depth = newDepth;
                Console.WriteLine($"The fish dives to a depth of {depth} meters.");
            }
        }

        public int GetDepth()
        {
            return depth;
        }

     
    }    
}

