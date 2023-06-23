using System;
using System.IO;

namespace ReadWriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\2107154\OneDrive - Cognizant\Documents\readWrite.txt");
            Console.WriteLine(text);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\2107154\OneDrive - Cognizant\Documents\readWrite.txt");
            foreach (string line in lines)
            {
                Console.WriteLine("\t"+line);
            }

            // Write to a file...
            string[] writableLines = { "First Line", "Second Line", "Third Line" };
            File.WriteAllLines(@"C:\Users\2107154\OneDrive - Cognizant\Documents\startWrite.txt", writableLines);

            using StreamWriter file = new StreamWriter(@"C:\Users\2107154\OneDrive - Cognizant\Documents\readWrite2.txt");
            foreach (string line in writableLines)
            {
                if (line.Contains("Line"))
                    file.WriteLine(line);
            }
        }
    }
}
