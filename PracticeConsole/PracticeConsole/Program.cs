using System;
using System.Collections.Generic;

namespace PracticeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"Hello World!
                uhuigiuguigu
                uuiguiguig

        gyigifgiu");
            const double PI = 3.14;
            Console.WriteLine(PI);
            Console.WriteLine("Enter a Number: ");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int res = a / 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error is: Format not correct!");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Error is: Zero Devision Error!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }
            string willParse = "123";
            int numm;
            bool isConverted = int.TryParse(willParse,out numm);
            if(isConverted)
                Console.WriteLine("Number converted successfully :"+numm);
            else
                Console.WriteLine("convertion failed!");
        }
    }
}
