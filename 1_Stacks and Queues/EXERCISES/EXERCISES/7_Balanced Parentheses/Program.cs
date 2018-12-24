using System;
using System.Collections.Generic;

namespace _7_Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var queue1 = new Queue<char>();
            var queue2 = new Queue<char>();

            var count = 0;

            for (int i = 0; i < input.Length/2; i++)
            {
                queue1.Enqueue(input[i]);
                queue2.Enqueue(input[input.Length - 1 - i]);
            }

            for (int i = 0; i < input.Length/2; i++)
            {
                var links = queue1.Dequeue();
                var right = queue2.Dequeue();

                if ((links == '{' && right == '}') || (links == '[' && right == ']') || (links == '(' && right == ')') || (links == ' ' && right == ' ') || (links == '}' && right == '{') || (links == ']' && right == '[') || (links == ')' && right == '(') )
                {
                    count++;
                }
            }
                    
            if (count == input.Length/2)
            {
                Console.WriteLine("YES");
            }

            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
