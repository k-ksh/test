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
            Dog dog1 = new Dog("Hope", "white", 40,"hav hav",4);
            Bird bird1 = new Bird("peacock", "multicolor", 10, "qua qua", 2);
            Fish fish1 = new Fish (1,"fish", "green", 7, "...", 3);

            
            dog1.MakeSound();
            bird1.Fly();
            bird1.MakeSound();

            Console.WriteLine($"Initial depth of the fish: {fish1.GetDepth()} meters");

            fish1.Dive(10);
            Console.WriteLine($"Current depth of the fish: {fish1.GetDepth()} meters");

            fish1.Dive(5);
            Console.WriteLine($"Current depth of the fish: {fish1.GetDepth()} meters");

         
            

        }

    }
            
 }
   

