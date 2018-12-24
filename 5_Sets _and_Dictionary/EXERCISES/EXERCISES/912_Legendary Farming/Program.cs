using System;
using System.Collections.Generic;
using System.Linq;

namespace _912_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var Legendery = new Dictionary<string, int>();

            Legendery["shards"] = 0;
            Legendery["motes"] = 0;
            Legendery["fragments"] = 0;

            var Remaining = new Dictionary<string, int>();

            var quantity = 0;
            var type = "";

            bool value = true;

            while (value == true)
            {
                var input = Console.ReadLine().Split(' ').ToList();

                for (int i = 0; i < input.Count; i = i + 2)
                {
                    quantity = int.Parse(input[i]);
                    type = input[i + 1].ToLower();

                    if (type == "shards" || type == "motes" || type == "fragments")
                    {
                        if (!Legendery.ContainsKey(type))
                        {
                            Legendery[type] = 0;
                        }

                        Legendery[type] += quantity;

                        if (Legendery[type] >= 250)
                        {
                            if (type == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                Legendery[type] -= 250;

                                value = false;
                            }

                            else if (type == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                Legendery[type] -= 250;

                                value = false;
                            }

                            else if (type == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                                Legendery[type] -= 250;

                                value = false;
                            }

                            break;
                        }
                    }

                    if (type != "shards" && type != "motes" && type != "fragments")
                    {

                        if (!Remaining.ContainsKey(type))
                        {
                            Remaining[type] = 0;
                        }

                        Remaining[type] += quantity;
                    }
                }
            }

            foreach (var x in Legendery.OrderByDescending(s => s.Value).ThenBy(r => r.Key))
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }

            foreach (var x in Remaining.OrderBy(d => d.Key))
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
        }
    }
}
