using System.Drawing;
using System.Xml.Linq;

namespace MyNamespace
{
    class Fish:Animal
    {
        public int depth;
        public Fish(int depth, string name, string color, double lenght,string sound):base(name, color, lenght,sound)
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

        public override void DescribeYourself()
        {
            base.DescribeYourself();
            Console.WriteLine($"This fish is currently at a depth of {depth} units.");
        }
    }    
}

