using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFirstrow = Console.ReadLine().Split().Select(long.Parse).ToList();
            var inputSecondRow = Console.ReadLine().Split().Select(long.Parse).ToList();

            var push = inputFirstrow[0];
            var pop = inputFirstrow[1];
            var matchnum = inputFirstrow[2];
           
            var stack = new Stack<long>();

            for (int i = 0; i < push; i++)
            {
                stack.Push(inputSecondRow[i]);
            }

            for (int i = 0; i < pop; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }

            else if (stack.Contains(matchnum))
            {
                Console.WriteLine("true");
            }

            else if (!stack.Contains(matchnum))
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}               
