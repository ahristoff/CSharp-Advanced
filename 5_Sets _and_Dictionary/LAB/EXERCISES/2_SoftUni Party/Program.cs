using System;
using System.Collections.Generic;

namespace _2_SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var reservation = new SortedSet<string>();

            var input = Console.ReadLine();

            while (input != "PARTY")
            {
                reservation.Add(input);
                input = Console.ReadLine();
            }

            while (input != "END")
            {
                reservation.Remove(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(reservation.Count);

            Console.WriteLine(string.Join('\n', reservation));
        }
    }
}
