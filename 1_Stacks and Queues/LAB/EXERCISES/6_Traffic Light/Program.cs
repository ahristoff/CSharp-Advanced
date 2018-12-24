using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Traffic_Light
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var command = Console.ReadLine();

            var queue = new Queue<string>();
            var sb = new StringBuilder();
            
            int count = 0;

            while (command != "end")
            {
                if (command != "green")
                {
                    queue.Enqueue(command);
                }

                else if (command == "green")
                {

                    if (queue.Count >= n)
                    {

                        for (int i = 0; i < n; i++)
                        {
                            sb.AppendLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }

                    else
                    {
                        while (queue.Count > 0)
                        {
                            sb.AppendLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            sb.AppendLine($"{count} cars passed the crossroads.");
            Console.WriteLine();
            Console.WriteLine(sb.ToString());
        }
    }
}
