using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _4_Academy_Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();

                var notes = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(r => double.Parse(r, CultureInfo.InvariantCulture)).ToList();

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<double>();
                }

                for (int j = 0; j < notes.Count; j++)
                {
                    dict[name].Add(notes[j]);
                }
            }

            foreach (var x in dict)
            {
                Console.WriteLine($"{x.Key} is graduated with {x.Value.Average()}");
            }
        }
    }
}
