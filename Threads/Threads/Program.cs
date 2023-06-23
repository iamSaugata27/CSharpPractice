using System;
using System.Threading;

namespace Threads
{
    internal class Program
    {
        private static object _locker = new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(DoWork);
                t.Start();
            }
        }
        public static void DoWork()
        {
            lock (_locker)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starting...");
                Thread.Sleep(2000);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} completed...");
            }
        }
    }
}
