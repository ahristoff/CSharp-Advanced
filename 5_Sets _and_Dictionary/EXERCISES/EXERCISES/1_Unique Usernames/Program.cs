using System;
using System.Collections.Generic;

namespace _1_Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var hashset = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                hashset.Add(Console.ReadLine());
            }
            
            Console.WriteLine(string.Join('\n',hashset));
        }
    }
}
