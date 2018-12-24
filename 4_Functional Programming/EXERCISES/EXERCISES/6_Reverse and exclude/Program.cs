using System;
using System.Linq;

namespace _6_Reverse_and_exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                       .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(int.Parse)
                       .ToList();

            var divisor = int.Parse(Console.ReadLine());

            Func<int, bool> IsDiviser  = n => n % divisor != 0;

            var nonDivisibleNumbers = numbers
                        .Where(IsDiviser)
                        .Reverse()
                        .ToList();

            Console.WriteLine(string.Join(" ", nonDivisibleNumbers));
        }
    }
}
