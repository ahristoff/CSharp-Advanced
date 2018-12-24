using System;
using System.Collections.Generic;
using System.Text;

namespace _910_Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            var history = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:

                        if (input.Length > 1)
                        {
                            history.Push(sb.ToString());
                            sb.Append(input[1]);
                        }

                        break;

                    case 2: 

                        if (input.Length > 1)
                        {
                            var count = int.Parse(input[1]);
                            history.Push(sb.ToString());

                            if (count > sb.Length)
                            {
                                sb.Clear();
                                break;
                            }

                            sb.Remove(sb.Length - count, count);
                        }

                        break;

                    case 3: 

                        if (input.Length > 1)
                        {
                            var index = int.Parse(input[1]);

                            if (index <= sb.Length && index > 0)
                            {
                                Console.WriteLine(sb[index - 1]);
                            }
                        }

                        break;

                    case 4: 

                        sb.Clear();
                        sb.Append(history.Pop());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
