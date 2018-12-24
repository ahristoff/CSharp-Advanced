using System;
using System.Linq;

namespace _1_Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> Print = n => Console.WriteLine(n);

            Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(Print);
        }
    }
}
