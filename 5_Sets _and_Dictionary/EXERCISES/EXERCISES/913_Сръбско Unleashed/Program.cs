using System;
using System.Collections.Generic;
using System.Linq;

namespace _913_Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    var comand = input.Split('@').ToList();
                    var last = comand[0].Last();

                    string name = null;

                    if (last == ' ')
                    {
                        name = comand[0];
                    }

                    var com = comand[1].Split(' ').ToList();

                    long ticketCount = long.Parse(com[com.Count - 1]);
                    long ticketPrise = long.Parse(com[com.Count - 2]);

                    long totalTicket = ticketPrise * ticketCount;

                    string city = null;

                    for (int i = 0; i < com.Count - 2; i++)
                    {
                        city += com[i] + " ";
                    }

                    if (!dict.ContainsKey(city))
                    {
                        dict[city] = new Dictionary<string, long>();
                    }

                    if (!dict[city].ContainsKey(name))
                    {
                        dict[city][name] = 0;
                    }

                    dict[city][name] += totalTicket;

                    input = Console.ReadLine();
                }

                catch
                {
                    input = Console.ReadLine();
                }
            }

            foreach (var x in dict)
            {
                Console.WriteLine(x.Key);

                foreach (var y in x.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine("#  {0}-> {1}", y.Key, y.Value);
                }

            }
        }
    }
}
