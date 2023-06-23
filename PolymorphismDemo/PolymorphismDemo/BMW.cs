using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class BMW:Car
    {
        private readonly string _brand="BMW";
        public string Model { get; set; }
        public BMW(int hp,string color,string model):base(hp,color)
        {
            this.Model = model;
        }
        public override void showDetails()
        {
            Console.WriteLine($"Brand of the car is {_brand},HP of the car is {HP} and color of the car is {Color}");
        }
        public override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired...",Model);
        }
    }
}
