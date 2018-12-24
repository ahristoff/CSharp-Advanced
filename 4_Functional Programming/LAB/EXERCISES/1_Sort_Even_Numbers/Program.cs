using System;
using System.Linq;

namespace _1_Sort_Even_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<string, int> NumParse = n => int.Parse(n);
            Func<int, bool> Check = n => n % 2 == 0;

            Action<int> Print = n => Console.Write(n + " ");

            Console.ReadLine()
                    .Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(NumParse)
                    .Where(Check)
                    .OrderBy(n => n)    
                    .ToList()
                    .ForEach(Print);                      
        }
    }
}
