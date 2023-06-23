using System;
using System.Collections.Generic;

namespace NextGreater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "hefg";
            /*
            string st = "2431";
            List<int> h = new List<int>();
            foreach (var item in st)
            {
                h.Add(int.Parse(item.ToString()));
            }
            bool flag = false;
            for (int i = h.Count - 1; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (h[i] > h[j])
                    {
                        (h[j], h[i]) = (h[i], h[j]);
                        flag = true;
                        break;
                    }
                }
                if (flag)
                    break;
            }
            string s = "";
            foreach (int item in h)
            {
                s += item.ToString();
            }
            if (s == st)
                Console.WriteLine("no other combination is possible to get higer bnumber from that");
            else
                Console.WriteLine(s);
            */

            /*
            string st = "dkhc";
            foreach (var item in st)
            {
                Console.WriteLine((int)item);
            }
            List<char> h = new List<char>();
            foreach (var item in st)
            {
                h.Add(item);
            }
            bool flag = false;
            for (int i = h.Count - 1; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (h[i] > h[j])
                    {
                        (h[j], h[i]) = (h[i], h[j]);
                        flag = true;
                        break;
                    }
                }
                if (flag)
                    break;
            }
            string s = "";
            foreach (char item in h)
            {
                s += item;
            }
            if (s == st)
                Console.WriteLine("no other combination is possible to get higer bnumber from that");
            else
                Console.WriteLine(s);

            */
        }
    }
}
