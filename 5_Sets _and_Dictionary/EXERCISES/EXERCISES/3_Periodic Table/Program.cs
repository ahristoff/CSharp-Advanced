using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var sortedSet = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < elements.Length; j++)
                {
                    sortedSet.Add(elements[j]);
                }              
            }

            Console.WriteLine(string.Join(' ', sortedSet));
        }
    }
}
