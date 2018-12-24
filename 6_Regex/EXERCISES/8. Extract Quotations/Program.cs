using System;
using System.Text.RegularExpressions;

namespace _8._Extract_Quotations
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = "('|\")(.+?)\\1";   // "\"(.+?)\"|'(.+?)'"

            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (Match x in matches)
            {
                Console.WriteLine(x.Groups[2].Value); 
            }
        }
    }
}
