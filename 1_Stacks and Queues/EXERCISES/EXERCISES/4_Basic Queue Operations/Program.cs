using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFirstrow = Console.ReadLine().Split().Select(int.Parse).ToList();
            var inputSecondRow = Console.ReadLine().Split().Select(int.Parse).ToList();

            var push = inputFirstrow[0];
            var pop = inputFirstrow[1];
            var matchnum = inputFirstrow[2];
        
            var queue = new Queue<int>();

            for (int i = 0; i < push; i++)
            {
                queue.Enqueue(inputSecondRow[i]);
            }

            for (int i = 0; i < pop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }

            else if (queue.Contains(matchnum))
            {
                Console.WriteLine("true");
            }

            else if(!queue.Contains(matchnum))
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
