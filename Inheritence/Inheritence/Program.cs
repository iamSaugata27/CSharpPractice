using System;

namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Duplicate();
            text.Width = 100;
        }
    }
}
