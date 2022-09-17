using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Square : Polygon
    {
        // TODO: Felder implementieren
        private float _x1, _y1, _x2, _y2, _length;

        // TODO: Konstruktor implementieren
        public Square(float x1, float y1, float length)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x1 + length;
            _y2 = y1 + length;
            _length = length;
        }

        // TODO: Basis-Members implementieren
        public override int NumSides => 4;

        public override float Area()
        {
            return _length * NumSides;
        }


        // TODO: X1 / X2 implementieren
        public float X1 { get => _x1 ; set { _x1 = value; } }
        public float X2 { get => _x2; set { _x2 = value; } }

        // TODO: Y1 / Y2 implementieren
        public float Y1 { get => _y2; set { _y1 = value; } }
        public float Y2 { get => _y2; set { _y2 = value; } }
    }
}
