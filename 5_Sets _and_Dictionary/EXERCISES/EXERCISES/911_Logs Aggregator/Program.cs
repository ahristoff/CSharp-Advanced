using System;
using System.Collections.Generic;
using System.Linq;

namespace _911_Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var com = Console.ReadLine().Split(' ').ToList();

                var id = com[0];
                var name = com[1];
                var duration = int.Parse(com[2]);

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new Dictionary<string, int>();
                }

                if (!dict[name].ContainsKey(id))
                {
                    dict[name][id] = 0;
                }

                dict[name][id] += duration;
            }

            var list = new List<string>();

            foreach (var x in dict.OrderBy(d => d.Key))
            {
                var sum = x.Value.Values.Sum();

                Console.Write("{0}: {1} ", x.Key, sum);

                foreach (var y in x.Value.OrderBy(s => s.Key))
                {
                    list.Add(y.Key);
                }

                Console.WriteLine("[{0}]", string.Join(", ", list));

                list.Clear();
            }
        }
    }
}
