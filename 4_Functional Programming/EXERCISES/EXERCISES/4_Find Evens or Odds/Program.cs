using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            var range = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .OrderBy(n => n)
                        .ToList();

            var oddOrEven = Console.ReadLine().ToLower();

            Func<int, bool> Odd = i => i % 2 == 1;
            Func<int, bool> Even = i => i % 2 == 0;

            for (int i = range[0]; i <= range[1]; i++)
            {
                list.Add(i);
            }

            if (oddOrEven == "odd")
            {
                var odd  = list.Where(Odd).ToList();

                if (odd.Count != 0)
                {
                    Console.WriteLine(string.Join(" ", odd));
                }        
            }

            else if(oddOrEven == "even")
            {
                var even = list.Where(Even).ToList();

                if (even.Count != 0)
                {
                    Console.WriteLine(string.Join(" ", even));
                }               
            }           
        }
    }
}
