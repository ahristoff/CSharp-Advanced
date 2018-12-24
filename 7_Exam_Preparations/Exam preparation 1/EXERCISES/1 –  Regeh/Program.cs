using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1_Regeh
{
    class Program
    {       
        static void Main(string[] args)
        {
            var list = new List<int>();

            var text = Console.ReadLine();
            var pattern = @"\[[^\[\s]+<(\d+)REGEH(\d+)>[^\]\s]+\]";

            var reg = new Regex(pattern);
            var matches = reg.Matches(text);

            foreach (Match x in matches)
            {
                list.Add(int.Parse(x.Groups[1].Value));
                list.Add(int.Parse(x.Groups[2].Value));
            }

            for (int i = 1; i < list.Count; i++)
            {
                list[i] = list[i - 1] + list[i];
            }

            string res = null;

            for (int i = 0; i < list.Count; i++)
            {
                res += text.Substring(list[i] % text.Length, 1);
            }

            Console.WriteLine(res);
        }
    }
}
