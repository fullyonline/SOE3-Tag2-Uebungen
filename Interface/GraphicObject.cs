using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IGraphicObject
    {
        void Draw();
    }

    //TODO Binding IGraphicObject
    class Circle : IGraphicObject
    {
        //TODO Field
        private string _name;

        //TODO Constructor
        public Circle(string name)
        {
            _name = name;
        }

        //TODO output Name Methode
        public void Draw()
        {
            Console.WriteLine($"Circle({_name})");
        }
    }

    //TODO Binding IGraphicObject
    class Rectangle : IGraphicObject
    {
        //TODO Field
        private string _name;

        //TODO Constructor
        public Rectangle(string name)
        {
            _name = name;
        }

        //TODO output Name Methode
        public void Draw()
        {
            Console.WriteLine($"Rectangle({_name})");
        }
    }

    //TODO Binding IGraphicObject
    class Compound : IGraphicObject
    {
        private string _name;
        List<IGraphicObject> objList = new List<IGraphicObject>();

        public Compound(string name) { this._name = name; }

        public void Draw()
        {
            Console.WriteLine("Verbindung: {0}", _name);
            foreach (IGraphicObject g in objList)
            {
                g.Draw();
            }
            Console.WriteLine("Ende-Verbindung: {0}", _name);
        }

        //TODO Add Methode an die ObjectList
        public void Add(IGraphicObject g)
        {
            objList.Add(g);
        }
    }
}
