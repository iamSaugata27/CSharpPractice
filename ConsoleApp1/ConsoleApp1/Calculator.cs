using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public int Addition(params int[] numbers)
        {
            int sum=0;
            foreach(int number in numbers)
            {
                sum+=number;
            }
            return sum;
        }
    }
}
