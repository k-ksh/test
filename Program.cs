using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Hope", "white", 40,"hav hav");
            Bird bird1 = new Bird(2,"peacock", "multicolor", 10, "qua qua");
            Fish fish1 = new Fish (5, "fish", "green", 7, "...");

            
            dog1.MakeSound();
            bird1.Fly();
            Console.WriteLine($"Initial depth of the fish: {fish1.GetDepth()} meters");

            fish1.Dive(10);
            Console.WriteLine($"Current depth of the fish: {fish1.GetDepth()} meters");

            fish1.Dive(5);
            Console.WriteLine($"Current depth of the fish: {fish1.GetDepth()} meters");

            fish1.DescribeYourself();
            dog1.DescribeYourself();
            bird1.DescribeYourself();
            

        }

    }
            
 }
   

