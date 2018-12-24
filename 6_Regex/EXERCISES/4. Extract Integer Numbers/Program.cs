using System;
using System.Text.RegularExpressions;

namespace _4._Extract_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"\d+";      

            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (Match x in matches)
            {
                Console.WriteLine(x.Value);
            }
        }
    }
}
