using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Boss:Employee
    {
        public string CompanyCar { get; set; }
        public Boss(string name,string firstname,int salary,string companyCar):base(name,firstname,salary)
        {
            this.CompanyCar = companyCar;
        }
        public void Lead()
        {
            Console.WriteLine("I am leading...");
        }
    }
}
