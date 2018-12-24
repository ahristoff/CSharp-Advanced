using System;
using System.Linq;

namespace _7_Predicate_for_names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Action<string> Print = c => Console.WriteLine(c);
            Func<string, bool> Filter = c => c.Length <= n;

            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(Filter)
                .ToList()
                .ForEach(Print);                                                                                   
        }
    }
}
