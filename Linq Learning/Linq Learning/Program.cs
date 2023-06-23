using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2,32,14,51,78,67,85,39};
            OddNumbers(numbers);
            SortNumbersByDescendingOrder(numbers);

            var manager = new UniversityManager();
            manager.MaleStudents();
            manager.FeMaleStudents();
            manager.SortStudentByAge();
            manager.AllStudentFromStandford();
            manager.StudentWithUniversityNameCollection();
            Console.WriteLine("Enter the university Id u want to get the students:");
            int uniID = int.Parse(Console.ReadLine());
            manager.AllStudentsFromSameUniversity(uniID);
        }
        static void OddNumbers(int[] numbers)
        {
            IEnumerable<int> oddnumbers = from number in numbers where number % 2 != 0 select number;
            Console.WriteLine(oddnumbers);
            foreach (int number in oddnumbers)
            {
                Console.WriteLine(number);
            }
        }

        static void SortNumbersByDescendingOrder(int[] numbers)
        {
            var sortDesc = from number in numbers orderby number descending select number;
            Console.WriteLine("Sort the numbers by descending order...");
            foreach (var num in sortDesc)
            {
                Console.WriteLine(num);
            }
        }
    }
}
