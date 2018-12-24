using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToList();

                if (input[0] == 1)
                {
                    stack.Push(input[1]);
                }

                else if (input[0] == 2)
                {
                    stack.Pop();
                }

                else if (input[0] == 3)
                {
                    Console.WriteLine(stack.Max());
                }
            }
        }
    }
}
