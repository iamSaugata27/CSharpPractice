using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Trainees:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }
        public Trainees(int workhour,int schoolhour,string name,string firstname,int salary):base(name,firstname,salary)
        {
            this.WorkingHours = workhour;
            this.SchoolHours = schoolhour;
        }
        public void Learn()
        {
            Console.WriteLine($"I am learning for {SchoolHours} hours");
        }
        public override void Work()
        {
            Console.WriteLine($"I am working for {WorkingHours} hours");
        }
    }
}
