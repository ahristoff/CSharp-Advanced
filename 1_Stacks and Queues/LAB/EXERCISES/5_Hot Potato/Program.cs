using System;
using System.Collections.Generic;

namespace _5_Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(children.Split(' '));

            while (queue.Count > 1)
            {

                for (int i = 0; i < n - 1; i++)
                {
                    string remainder = queue.Dequeue(); 
                    
                    queue.Enqueue(remainder);                   
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
