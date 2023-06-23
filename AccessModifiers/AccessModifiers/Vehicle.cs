using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Vehicle
    {
        private readonly string _registrationNo;
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized!");
        //}
        public Vehicle(string registrationNumber)
        {
            _registrationNo = registrationNumber;
            Console.WriteLine("Vehicle is being initialized! and regNo is {0}",registrationNumber);
        }
    }
}
