using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_Hands_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            var comand = Console.ReadLine();

            string name = null;
            string game = null;

            while (comand != "JOKER")
            {
                var com = comand.Split(':');

                name = com[0];
                game = com[1];

                var cards = game.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<string>();
                }

                for (int i = 0; i < cards.Count; i++)
                {
                    dict[name].Add(cards[i]);
                }

                dict[name] = dict[name].Distinct().ToList();

                comand = Console.ReadLine();
            }

            foreach (var x in dict)
            {
                var sum = 0;

                for (int i = 0; i < x.Value.Count; i++)
                {

                    var power = x.Value[i].Substring(0, x.Value[i].Length - 1);
                    var type = x.Value[i].Substring(x.Value[i].Length - 1);

                    if (power == "J")
                    {
                        power = 11.ToString();
                    }

                    else if (power == "Q")
                    {
                        power = 12.ToString();
                    }

                    else if (power == "K")
                    {
                        power = 13.ToString();
                    }

                    else if (power == "A")
                    {
                        power = 14.ToString();
                    }

                    if (type == "S")
                    {
                        type = 4.ToString();
                    }

                    else if (type == "H")
                    {
                        type = 3.ToString();
                    }

                    else if (type == "D")
                    {
                        type = 2.ToString();
                    }

                    else if (type == "C")
                    {
                        type = 1.ToString();
                    }

                    int pow = int.Parse(power);
                    int typ = int.Parse(type);

                    sum += (pow * typ);
                }

                Console.WriteLine("{0}: {1}", x.Key, sum);
            }
        }
    }
}
