using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var queue1 = new Queue<int>();
            var queue2 = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToList();
                var petrol = input[0];
                var distance = input[1];

                var need = petrol - distance;

                queue1.Enqueue(i);
                queue2.Enqueue(need);
            }

            var list = queue2.ToList();

            for (int i = 0; i < n; i++)
            {
                var sum = 0;
                int count = 0;

                for (int j = 0; j < n; j++)
                {
                    sum += list[j];

                    if (sum < 0)
                    {
                        var element2 = queue2.Dequeue();
                        queue2.Enqueue(element2);

                        var element1 = queue1.Dequeue();
                        queue1.Enqueue(element1);

                        list = queue2.ToList();

                        break;
                    }

                    count++;
                }

                if (count == n)
                {
                    Console.WriteLine(queue1.Peek());

                    break;
                }
            }
        }
    }
}
