using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Greedy_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictGold = new Dictionary<string, Dictionary<string, long>>();
            var dictGem = new Dictionary<string, Dictionary<string, long>>();
            var dictCash = new Dictionary<string, Dictionary<string, long>>();

            long n = long.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var type = "";
            long quantity = 0;
            long sumGold = 0;
            long sumGem = 0;
            long sumCash = 0;

            for (int i = 0; i < input.Count; i = i + 2)
            {
                type = input[i];
                quantity = long.Parse(input[i + 1]);
                //gold
                if (type.ToLower() == "gold")
                {
                    if (!dictGold.ContainsKey("<Gold>"))
                    {
                        dictGold["<Gold>"] = new Dictionary<string, long>();
                    }

                    if (!dictGold["<Gold>"].ContainsKey(type))
                    {
                        dictGold["<Gold>"][type] = 0;
                    }

                    if (n >= sumCash + sumGem + sumGold + quantity)
                    {
                        dictGold["<Gold>"][type] += quantity;
                    }
                }

                foreach (var x in dictGold)
                {
                    sumGold = x.Value.Values.Sum();
                }

                //gem                            
                if (type.ToLower().EndsWith("gem") && type.Length >= 4)
                {

                    if (!dictGem.ContainsKey("<Gem>"))
                    {
                        dictGem["<Gem>"] = new Dictionary<string, long>();
                    }

                    if (!dictGem["<Gem>"].ContainsKey(type))
                    {
                        dictGem["<Gem>"][type] = 0;
                    }

                    if (sumGold >= sumGem + quantity && n >= sumCash + sumGem + sumGold + quantity)
                    {
                        dictGem["<Gem>"][type] += quantity;
                    }
                }

                foreach (var x in dictGem)
                {
                    sumGem = x.Value.Values.Sum();
                }

                if (type.Length == 3)
                {
                    if (!dictCash.ContainsKey("<Cash>"))
                    {
                        dictCash["<Cash>"] = new Dictionary<string, long>();
                    }

                    if (!dictCash["<Cash>"].ContainsKey(type))
                    {
                        dictCash["<Cash>"][type] = 0;
                    }

                    if (sumGem >= sumCash + quantity && n >= sumCash + sumGem + sumGold + quantity)
                    {
                        dictCash["<Cash>"][type] += quantity;
                    }
                }

                foreach (var x in dictCash)
                {
                    sumCash = x.Value.Values.Sum();
                }
            }

            PrintBag(dictGold);

            PrintBag(dictGem);

            PrintBag(dictCash);
        }

        private static void PrintBag(Dictionary<string, Dictionary<string, long>> dict)
        {

            foreach (var x in dict)
            {
                long sum = x.Value.Values.Sum();

                if (sum > 0)
                {
                    Console.WriteLine($"{x.Key} ${sum}");
                }

                foreach (var y in x.Value.OrderByDescending(s => s.Key).ThenBy(b => b.Value))
                {
                    if (y.Value > 0)
                    {
                        Console.WriteLine($"##{y.Key} - {y.Value}");
                    }
                }
            }
        }
    }
}
