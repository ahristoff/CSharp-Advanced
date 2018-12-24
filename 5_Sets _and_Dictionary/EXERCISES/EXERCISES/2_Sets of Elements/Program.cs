using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var hashSet = new HashSet<int>();

            for (int i = 0; i < command[0]; i++)
            {
                hashSet.Add(int.Parse(Console.ReadLine()));
            }

            var list = new List<int>();

            for (int i = 0; i < command[1]; i++)
            {
                var match = int.Parse(Console.ReadLine());

                if (hashSet.Contains(match))
                {
                    list.Add(match);
                }
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
