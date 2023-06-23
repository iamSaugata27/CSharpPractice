using System;
using System.Collections.Generic;

namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new BMW(500,"Brown","M3S"),
                new Audi(420,"Black","ESport")
            };

            Car bmw = new BMW(190, "Red", "Z5");
            Car audi = new Audi(220, "Blue", "TTS Coupe");
            bmw.setCarIdInfo(123, "Saugata");
            audi.setCarIdInfo(125, "Saugata Shee");
            bmw.getCarIdInfo();
            audi.getCarIdInfo();

            foreach (var car in cars)
            {
                car.showDetails();
                car.Repair();
            }
        }
    }
}
