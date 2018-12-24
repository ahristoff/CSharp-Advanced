using System;
using System.Linq;

namespace _8_Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> Filter = n => Math.Abs(n) % 2 == 0;

            var nums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var numsEven = nums
                 .Where(n =>Filter(n))
                 .OrderBy(n => n)
                 .ToList();

            var numsOdd = nums
                .Where(n =>!Filter(n))
                 .OrderBy(n => n)
                 .ToList();

            var res = numsEven.Concat(numsOdd);

            Console.WriteLine(string.Join(" ", res));
        }
    }
}
