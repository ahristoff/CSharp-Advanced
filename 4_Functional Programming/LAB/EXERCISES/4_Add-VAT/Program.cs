using System;
using System.Linq;

namespace _4_Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> DecimalParse = n => double.Parse(n);
            Func<double, double> Percent = n => n = n * 1.2;

            Action<double> Print = n => Console.WriteLine($"{n:f2}");

            Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(DecimalParse)
                .Select(Percent)
                .ToList()
                .ForEach(Print);         
        }
    }
}
