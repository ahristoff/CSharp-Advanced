using System;
using System.Collections.Generic;
using System.Linq;

namespace _910_Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, long>>();

            var comand = Console.ReadLine();

            while (comand != "report")
            {
                var com = comand.Split('|').ToList();

                string city = com[0];
                string country = com[1];
                long population = long.Parse(com[2]);


                if (!dict.ContainsKey(country))
                {
                    dict[country] = new Dictionary<string, long>();
                }

                if (!dict[country].ContainsKey(city))
                {
                    dict[country][city] = 0;
                }

                dict[country][city] += population;

                comand = Console.ReadLine();
            }

            foreach (var x in dict.OrderByDescending(s => s.Value.Values.Sum()))
            {
                Console.WriteLine("{0} (total population: {1})", x.Key, x.Value.Values.Sum());

                foreach (var y in x.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine("=>{0}: {1}", y.Key, y.Value);
                }
            }
        }
    }
}
