using System;
using System.Linq;

namespace _2_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Func<string, int> parser = n => int.Parse(n);

            Console.WriteLine(input
               .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(parser)
               .Count());

            Console.WriteLine(input
                .Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)               
                .Sum());
        }
    }
}
