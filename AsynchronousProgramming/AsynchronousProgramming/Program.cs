using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Async Method call....");
            var result2 = MyAsyncMethod(5);
            Console.WriteLine("...Sync Method call....");
            var result1=MySyncMethod(5);
            Console.WriteLine($"Sync Method call result: {result1}");
            Console.WriteLine($"Async Method call result: {result2.Result}");
        }
        private static int MySyncMethod(int count)
        {
            int result = 0;
            for (int i = 1; i <= count; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine($"Sync Number prints: {i}");
                result += i;
            }
            return result;
        }
        private static Task<int> MyAsyncMethod(int count)
        {
            Task<int> task = new Task<int>(() =>
              {
                  int result = 0;
                  for (int i = 1; i <= count; i++)
                  {
                      Thread.Sleep(200);
                      Console.WriteLine($"Async Number prints: {i}");
                      result += i;
                  }
                  return result;
              }
            );
            task.Start();
            return task;
        }
    }
}
