using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Erzeuge Square-Objekt

            float x, y, lenght;
            Console.WriteLine("Geben Sie X ein:");
            if(!float.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Dies war keine Zahl.");
                return;
            }

            Console.WriteLine("Geben Sie Y ein:");
            if (!float.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Dies war keine Zahl.");
                return;
            }

            Console.WriteLine("Geben Sie die Länge ein:");
            if (!float.TryParse(Console.ReadLine(), out lenght))
            {
                Console.WriteLine("Dies war keine Zahl.");
                return;
            }

            Square square = new Square(x, y, lenght);        

            // TODO: Ausgabe Degrees
            Console.WriteLine("Degrees: {0}", square.Degrees);

            // TODO: Ausgabe Area()
            Console.WriteLine("Area: {0}", square.Area());

            // TODO: Ausgabe X1, Y1, X2, Y2
            Console.WriteLine($"(X1, Y1):({square.X1}, {square.Y1}) (X2, Y2):({square.X2}, {square.Y2})");

            Console.ReadKey();
        }
    }
}
