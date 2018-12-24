using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            var sb = new StringBuilder();

            var command = Console.ReadLine();

            while (command != "search")
            {
                var com = command.Split("-");

                dict[com[0]] = com[1];

                command = Console.ReadLine();
            }

            while (command != "stop")
            {

                if (command == "search")
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (dict.ContainsKey(command))
                {

                    foreach (var x in dict)
                    {

                        if (x.Key == command)
                        {                           
                            sb.AppendLine(String.Format("{0} -> {1}", x.Key, x.Value));
                        }
                    }
                }

                else
                {
                    sb.AppendLine(String.Format("Contact {0} does not exist.", command));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
