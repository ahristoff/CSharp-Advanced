using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _5._Extract_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var list = new List<MatchCollection>();

            MatchCollection matches = null;

            while (text != "END")
            {
                var pattern = @"<.*?>"; 

                var regex = new Regex(pattern);
                matches = regex.Matches(text);

                list.Add(matches);

                text = Console.ReadLine();
            }

            if (matches.Count ==  0)
            {
                Console.WriteLine("no output");
            }

            else
            {
                foreach (MatchCollection x in list)
                {
                    foreach (Match y in x)
                    {
                        Console.WriteLine(y);
                    }
                }
            }         
        }
    }
}
