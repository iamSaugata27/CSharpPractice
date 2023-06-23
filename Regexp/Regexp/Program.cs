using System;
using System.Text.RegularExpressions;

namespace Regexp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
            string text = "Hi, there my number is 123456";
            Regex regexp = new Regex(pattern);
            MatchCollection matching=regexp.Matches(text);
            foreach (Match item in matching)
            {
                GroupCollection grp = item.Groups;
                Console.WriteLine($"Value {grp[0].Value} found in index {grp[0].Index}");
            }
            int? num1 = null;
            int? num2 = 56;
            int num3,num4;
            num3 = num1 ?? 21;
            num4 = num2 ?? 75;
            Console.WriteLine($"num1={num1}, num2={num2}, num3={num3} and num4={num4}");
        }
    }
}
