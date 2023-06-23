using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnnumer
{
    internal class Dog
    {
        public string Name { get; set; }
        public bool IsNaughty { get; set; }
        public Dog(string name,bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughty = isNaughtyDog;
        }
        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine($"Dog {Name} said woaff!! {numberOfTreats} times");
        }
    }
}
