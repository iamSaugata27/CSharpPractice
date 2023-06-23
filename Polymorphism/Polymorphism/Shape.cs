using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shape
    {
        public int Width {get;set;}
        public int Height { get; set; }
        public virtual void Draw()
        {

        }
    }

    public class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle...");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle...");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle...");
        }
    }
}
