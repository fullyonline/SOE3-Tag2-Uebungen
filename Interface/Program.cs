using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Compound("Comp1");
            c1.Add(new Rectangle("R1"));
            c1.Add(new Circle("C1"));
            //TODO Rest
            var c2 = new Compound("Comp2");
            c2.Add(new Rectangle("R22"));
            c2.Add(new Circle("C22"));
            c2.Add(new Rectangle("R23"));
            c2.Add(new Circle("C25"));

            c1.Add(c2);
            c1.Add(new Rectangle("R33"));
            c1.Add(new Circle("C33"));


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Drawing... (dynamic binding)");
            Console.WriteLine("-------------------------------------------");
            c1.Draw();

            Console.ReadKey();
        }
    }
}
