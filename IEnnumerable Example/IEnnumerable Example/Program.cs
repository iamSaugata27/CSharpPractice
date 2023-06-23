using System;
using System.Collections.Generic;

namespace IEnnumerable_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> unknownCollection = GetCollection(1);
            Console.WriteLine("Option is 1 so,This was a List...");
            foreach (int number in unknownCollection)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine("");

            unknownCollection = GetCollection(2);
            Console.WriteLine("Option is 2 so, This was a Queue");
            foreach (int number in unknownCollection)
            {
                Console.Write(number+" ");
            }
        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numberlist = new List<int>() { 1, 2, 3, 4, 5 };
            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
                return numberlist;
            else if (option == 2)
                return numbersQueue;
            else
                return new int[] { 11, 12, 13, 14, 15 };
        }
    }
}
