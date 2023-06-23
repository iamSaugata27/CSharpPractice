using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }
        protected CarIdInfo carIdInfo = new CarIdInfo();
        public void setCarIdInfo(int id,string owner)
        {
            carIdInfo.IdNo = id;
            carIdInfo.Owner = owner;
        }
        public void getCarIdInfo()
        {
            Console.WriteLine($"The car has id no {carIdInfo.IdNo} and is owned by {carIdInfo.Owner}");
        }
        public Car(int hp,string color)
        {
            this.HP = hp;
            this.Color = color;
        }
        public virtual void showDetails()
        {
            Console.WriteLine($"HP of the car is {HP} and color of the car is {Color}");
        }
        public virtual void Repair()
        {
            Console.WriteLine("The car was repaired...");
        }
    }
}
