using System;

namespace IEnnumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            foreach(Dog dog in shelter)
            {
                if (!dog.IsNaughty)
                    dog.GiveTreat(2);
                else
                    dog.GiveTreat(1);
            }
        }
    }
}
