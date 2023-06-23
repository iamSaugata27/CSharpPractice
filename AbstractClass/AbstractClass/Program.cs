using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();
            circle.Copy();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
