using System;
using System.Collections;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class calculate
    {
        public int num1;
        private int num2;
        public int sum(int num1,int num2)
        {
            return num1 + num2;
        }
    }
    internal class Program
    {
        public static void cube(int n)
        {
            n = n * n * n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Type t = typeof(StreamReader);
            Console.WriteLine(t.FullName);
            if (t.IsClass) Console.WriteLine("Is a class");
            if (t.IsAbstract) Console.WriteLine("is abstrruct");
            else Console.WriteLine("is concrete");
            string str = "Pearl is nice";
            Console.WriteLine(str.Replace("white","nice"));

            try
            {
                int[] a = { 1, 2, 3, 4, 5 };
                for(int i=0;i<5;i++)
                {
                    Console.WriteLine(a[i]);
                }
                int x = (1 / Convert.ToInt32(0));
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine('A');
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("B");
            }
            int n = 3;
            cube(n);
            Console.WriteLine($"cube : {n}");
            calculate cal = new calculate();
            Console.WriteLine($"{cal.num1}=> {cal.sum(20,30)}");

            List<bool> list = new List<bool>();
            list.Add(true);
            list.Add(false);
            list.Add(true);
            Console.WriteLine(list.Count);
            list.Clear();
            Console.WriteLine(list.Count);
            // duplicate removal
            List<int> ranked = new List<int> { 100, 90, 90, 80 };
            ranked.Sort();
            ranked=ranked.Distinct().ToList();
            foreach(int num in ranked)
            {
                Console.WriteLine(num);
            };
        }
    }
}
