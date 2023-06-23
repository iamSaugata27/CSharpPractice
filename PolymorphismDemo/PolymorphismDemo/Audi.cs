using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Audi:Car
    {
        private readonly string _brand = "AUDI";
        public string Model { get; set; }
        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }
        public override void showDetails()
        {
            Console.WriteLine($"Brand of the car is {_brand},HP of the car is {HP} and color of the car is {Color}");
        }
        public override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired...", Model);
        }
    }
}
