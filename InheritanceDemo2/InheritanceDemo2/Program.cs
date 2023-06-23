using System;

namespace InheritanceDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Saugata Shee", "Saugata", 50000);
            emp.Work();
            emp.Pause();
            Boss boss = new Boss("Vishal Ghosh","Vish",75000,"Mercedes");
            boss.Lead();
            Trainees trainee = new Trainees(32,18,"BC","Bancho",10000);
            trainee.Work();
            trainee.Learn();
        }
    }
}
