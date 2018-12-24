using System;
using System.Collections.Generic;
using System.Linq;

namespace _911_Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 var
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(input);

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(stack.Pop() + " ");
            }

            Console.WriteLine();


            //2 var
            //var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //var stack = new Stack<int>(input);
            //Console.WriteLine(string.Join(" ",stack));           
        }
    }
}
