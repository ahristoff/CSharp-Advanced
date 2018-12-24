using System;
using System.Collections.Generic;
using System.Linq;

namespace _9_User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var nestDict = new Dictionary<string, Dictionary<string, int>>();

            var comand = Console.ReadLine();

            while (comand != "end")
            {
                var com = comand.Split(' ').ToList();

                var ipNum = com[0].Split('=');
                var userName = com[2].Split('=');

                var ip = ipNum[1];
                var mess = com[1];
                var name = userName[1];

                if (!nestDict.ContainsKey(name))
                {
                    nestDict[name] = new Dictionary<string, int>();
                }

                if (!nestDict[name].ContainsKey(ip))
                {
                    nestDict[name][ip] = 0;
                }

                nestDict[name][ip]++;

                comand = Console.ReadLine();
            }

            int count = 0;

            foreach (var x in nestDict.OrderBy(s => s.Key))
            {
                Console.WriteLine(x.Key + ": ");

                foreach (var y in x.Value)
                {
                    count++;

                    if (count == x.Value.Count)
                    {
                        Console.WriteLine("{0} => {1}. ", y.Key, y.Value);
                    }

                    else
                    {
                        Console.Write("{0} => {1}, ", y.Key, y.Value);
                    }
                }

                count = 0;
            }
        }
    }
}
