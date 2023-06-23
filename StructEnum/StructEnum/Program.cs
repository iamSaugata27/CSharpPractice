using System;

namespace StructEnum
{
    internal class Program
    {
        struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public void Display()
            {
                Console.WriteLine($"The game's name is {name}, the developer of the game is {developer} and rating is {rating}");
            }
        }
        enum Day
        {
            Mon,Tue,Wed,Thu,Fri,Sat,Sun
        }
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.name = "Mario";
            game1.developer = "Saugata Shee";
            game1.rating = 4.7;
            game1.Display();

            Day day = Day.Fri;
            Console.WriteLine((int)day);

            Random range = new Random();
            int num;
            for (int i = 0; i < 10; i++)
            {
                num = range.Next(3, 9);
                Console.WriteLine(num);
            }
        }
    }
}
