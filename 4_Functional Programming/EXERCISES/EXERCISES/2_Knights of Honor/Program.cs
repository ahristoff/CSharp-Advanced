using System;
using System.Linq;

namespace _2_Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> Print = n => Console.WriteLine($"Sir {n}");

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(Print);
        }
    }
}
