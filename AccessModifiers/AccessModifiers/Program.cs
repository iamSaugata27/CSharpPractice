using System;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var customer = new Customer();
            customer.Promote();
            var car = new Car("abc1234");
        }
    }
}
