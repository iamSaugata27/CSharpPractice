using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }
        public virtual void Work()
        {
            Console.WriteLine("I am Working!");
        }
        public virtual void Pause()
        {
            Console.WriteLine("I'm having a break");
        }
        public Employee()
        {
            Name = "Saugata Shee";
            FirstName = "Saugata";
            Salary = 26249;
        }
        public Employee(string name,string firstname,int salary)
        {
            this.Name = name;
            this.FirstName = firstname;
            this.Salary = salary;
        }
    }
}
