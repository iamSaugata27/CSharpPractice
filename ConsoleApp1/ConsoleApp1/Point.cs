using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point
    {
        public int x;
        public int y;
        public Point(int a,int b)
        {
            x = a; y = b;
        }
        public void Move(int c,int d)
        {
            x=c; y=d;
        }
        public void Move(Point newLocation)
        {
            Move(newLocation.x,newLocation.y);
        }
    }
}
