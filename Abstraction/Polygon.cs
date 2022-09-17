using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Polygon
    {
        public abstract int NumSides { get; } //Anzahl Seiten
        public int Degrees // Total Grade einem Polygon
        {
            get => (NumSides - 2) * 180;
        }
        public abstract float Area(); //Grösse der Fläche
    }
}
