using System;
using System.Text.RegularExpressions;

namespace _2._Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"[aoueijyAEOUIJY]";
            var text = Console.ReadLine();

            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            Console.WriteLine("Vowels: {0}", matches.Count);
        }
    }
}
