using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");
            Car damagedCar = new Car(90f, "Blue");
            damagedCar.DestroyableNearby.Add(officeChair);
            damagedCar.DestroyableNearby.Add(gamingChair);
            damagedCar.Destroy();
        }
    }
}
