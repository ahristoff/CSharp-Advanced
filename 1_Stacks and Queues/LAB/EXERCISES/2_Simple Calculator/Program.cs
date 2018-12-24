using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Simple_Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                String sign = stack.Pop();
                int second = int.Parse(stack.Pop());

                if (sign == "+")
                {
                    stack.Push((first + second).ToString());
                }

                else if (sign == "-")
                {
                    stack.Push((first - second).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
