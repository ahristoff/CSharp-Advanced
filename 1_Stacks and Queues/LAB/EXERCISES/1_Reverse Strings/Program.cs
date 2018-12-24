using System;
using System.Collections.Generic;

namespace _1_Reverse_Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            var input = Console.ReadLine();
            var stack = new Stack<char>(input);  
         
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();          
        }
    }
}
