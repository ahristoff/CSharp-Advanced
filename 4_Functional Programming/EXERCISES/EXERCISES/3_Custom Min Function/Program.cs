using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> Parser = n => int.Parse(n);           
            Func<List<int>, int> Min = n => n.Min();

            var nums = Console.ReadLine()
                 .Split()
                 .Select(Parser)
                 .ToList();

            Console.WriteLine(Min(nums));
        }
    }
}
