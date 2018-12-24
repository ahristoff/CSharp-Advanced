using System;
using System.Collections.Generic;

namespace _5_Calculate_Sequence_with_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();

            queue.Enqueue(n);
            var substitute = n;
            int count = 0;

            for (int i = 0 ; i < 49; i++)
            {
                if (i % 3 == 0)
                {
                    substitute = queue.ToArray()[count];
                    queue.Enqueue(substitute + 1);
                    count++;                  
                }

                else if (i % 3 == 1)
                {
                    queue.Enqueue((2 * substitute + 1));                   
                }

                else if (i % 3 == 2)
                {
                    queue.Enqueue(substitute + 2);                  
                }
            }

            Console.WriteLine(string.Join(" ", queue));
        }
    }
}
