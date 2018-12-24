﻿using System;
using System.Collections.Generic;

namespace _4_Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {               
                if (input[i] == '(')
                {
                    stack.Push(i);           
                }

                else if (input[i] == ')')
                {
                    int startIndex = stack.Pop();

                    string contents = input.Substring(startIndex, i - startIndex + 1);

                    Console.WriteLine(contents);
                }
            }
        }
    }
}
