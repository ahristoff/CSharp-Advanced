using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _4_Treasure_Map
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var text = Console.ReadLine();

                var pattern = @"#[^#!]{13,}!|![^#!]{13,}#";
                var regex = new Regex(pattern);

                var matches = regex.Matches(text);

                var list = new List<string>();

                for (int j = 0; j < matches.Count; j++)
                {
                    var patt = @"[^\w]([a-zA-Z]{4})[^\w].*(?<!\d)([0-9]{3})-([0-9]{4}|[0-9]{6})(?!\d)";
                    var reg = new Regex(patt);
                    var currMatch = reg.Match(matches[j].Value);

                    if (currMatch.Success)
                    {
                        list.Add($"Go to str. {currMatch.Groups[1].Value} {currMatch.Groups[2].Value}. Secret pass: {currMatch.Groups[3].Value}.");
                    }
                }               

                Console.WriteLine(list[list.Count/2]);
            }
        }
    }
}

