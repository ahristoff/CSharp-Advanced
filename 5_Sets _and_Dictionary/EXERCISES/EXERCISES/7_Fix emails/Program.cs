using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_Fix_emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> order = new Dictionary<string, string>();

            var line = Console.ReadLine();

            while (line != "stop")
            {
                var name = line;
                var email = Console.ReadLine();

                var avoidEmails = email.Skip(email.Length - 2).Take(2).ToList();

                if ((avoidEmails[0] == 'u' && avoidEmails[1] == 's') || (avoidEmails[0] == 'u' && avoidEmails[1] == 'k'))
                {
                    line = Console.ReadLine();
                    continue;
                }

                order[name] = email;

                line = Console.ReadLine();
            }

            foreach (var x in order)
            {
                Console.WriteLine($"{x.Key} -> {x.Value}");
            }
        }
    }
}
