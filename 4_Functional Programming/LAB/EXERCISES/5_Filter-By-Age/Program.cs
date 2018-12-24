using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var people = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!dict.ContainsKey(people[0]))
                {
                    dict[people[0]] = 0;
                }

                dict[people[0]] = int.Parse(people[1]);
            }

            var state = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Func<int, bool> tester = CreateTester(state, age);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);

            InvokePrinter(dict, tester, printer);
        }

        private static void InvokePrinter(
            Dictionary<string, int> dict,
            Func<int, bool> tester,
            Action<KeyValuePair<string, int>> printer
            )
        {
            foreach (var x in dict)
            {
                if (tester(x.Value))
                {
                    printer(x);
                }
            }
        }

        private static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name": return x => Console.WriteLine("{0}", x.Key);
                case "name age": return x => Console.WriteLine("{0} - {1}", x.Key, x.Value);
                case "age": return x => Console.WriteLine("{0}", x.Value);

                default: return null;
            }
        }

        private static Func<int, bool> CreateTester(string state, int age)
        {
            switch (state)
            {
                case "older": return x => x > age;
                case "younger": return x => x < age;

                default: return null;
            }
        }
    }
}
