using System;
using System.Collections.Generic;
using System.Linq;

namespace _9_List_of_Predicates
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var divisors = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .Distinct()
                        .ToList();

            var divisibleNumbers = GetDivisibleNumbers1ToN(n, divisors);

            Console.WriteLine(string.Join(" ", divisibleNumbers));
        }

        private static List<int> GetDivisibleNumbers1ToN(int n, List<int> divisors)
        {
            var divisibleNumbers = new List<int>();

            for (int num = 1; num <= n; num++)
            {
                var isDivisible = true;

                foreach (var x in divisors)
                {
                    Func<int, bool> isNotDivisor = c => num % c != 0;

                    if (isNotDivisor(x))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    divisibleNumbers.Add(num);
                }
            }

            return divisibleNumbers;
        }
    }
}
