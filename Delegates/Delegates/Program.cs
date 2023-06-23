using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person p);  // this is hand made delegate
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Alu", "Vishal", "Raktim", "Makal" };
            Console.WriteLine("Before All...........");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            names.RemoveAll(Filter);

            Console.WriteLine("After All...........");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            static bool Filter(string s)
            {
                return s.Contains("l");
            }


            // Delegate hand-made
            Person p1 = new Person() { Name = "John", Age = 25 };
            Person p2 = new Person() { Name = "Tom", Age = 65 };
            Person p3 = new Person() { Name = "Bot", Age = 15 };
            Person p4 = new Person() { Name = "Dot", Age = 30 };
            List<Person> persons = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids:", persons, IsMinor);
            DisplayPeople("Adults:", persons, IsAdult);
            DisplayPeople("Seniors:", persons, IsSenior);

            // Anonymous Method
            FilterDelegate anonymousMethod = delegate (Person p)
            {
                  return p.Age > 20 && p.Age < 30;
  
            };
            DisplayPeople("Between 20 and 30 years old:", persons, anonymousMethod);

            // With Lambda Expression
            DisplayPeople("People whose age is 30 years:", persons, p => p.Age == 30);
        }

            static void DisplayPeople(string title,List<Person> people,FilterDelegate filter)
            {
                Console.WriteLine(title);
                foreach (Person person in people)
                {
                    if(filter(person))
                    {
                        Console.WriteLine($"{person.Name} {person.Age} years old...");
                    }
                }
            }
            // filters for DisplayPeople method

            static bool IsMinor(Person p)
            {
                return p.Age <= 18;
            }
            static bool IsAdult(Person p)
            {
                return p.Age > 18 && p.Age < 60;
            }
            static bool IsSenior(Person p)
            {
                return p.Age >= 60;
            }
    }
}
