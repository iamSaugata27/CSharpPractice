using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(5,"john");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();
            Console.WriteLine($"Total order is: {customer.Orders.Count}");
            var order= new Order();
            var point = new Point(10, 30);
            point.Move(new Point(50, 60));
            Console.WriteLine($"Point is {point.x} and {point.y}");

            var calc=new Calculator();
            int result=calc.Addition(2, 5, 7, 9);
            Console.WriteLine($"Summation result is {result}");
            customer.Orders.Add(order);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var person=new Person();
            person.SetBirthDate(new DateTime(2022,01,27));
            Console.WriteLine(person.GetBirthDate());

            var personNew = new PersonNew(new DateTime(2020, 01, 27));
            Console.WriteLine(personNew.Age);

            var cookie = new Indexers();
            cookie["name"] = "Saugata";
            Console.WriteLine(cookie["name"]);
        }
    }
}
