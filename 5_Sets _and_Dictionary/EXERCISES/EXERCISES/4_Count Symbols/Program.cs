using System;
using System.Collections.Generic;

namespace _4_Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<char, int>();

            var text = Console.ReadLine().ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (!dict.ContainsKey(text[i]))
                {
                    dict[text[i]] = 1;
                }

                else
                {
                    dict[text[i]]++;
                }
            }

            foreach (var x in dict)
            {
                Console.WriteLine("{0}: {1} time/s", x.Key, x.Value);
            }
        }
    }
}
