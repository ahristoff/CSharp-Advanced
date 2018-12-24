using System;
using System.Text.RegularExpressions;

namespace _3._Non_Digit_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"\D";

            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            Console.WriteLine($"Non Digit: {matches.Count}");
        }
    }
}
