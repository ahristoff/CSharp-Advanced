using System;
using System.Linq;

namespace _913_TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

            Func<string, int> sumChars = s => s.ToCharArray().Sum(ch => ch);
            Func<string, int, bool> isEqualOrLargerSum = (s, n) => sumChars(s) >= n;

            var name = names.FirstOrDefault(n => isEqualOrLargerSum(n, sum));

            Console.WriteLine(name);
        }
    }
}
