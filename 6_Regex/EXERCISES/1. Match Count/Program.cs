using System;
using System.Text.RegularExpressions;

namespace _1._Match_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            Console.WriteLine(matches.Count);

            //foreach (Match x in matches)
            //{
            //    Console.WriteLine("Match {0} -> Index {1}", x.Value, x.Index);
            //}
        }
    }
}
