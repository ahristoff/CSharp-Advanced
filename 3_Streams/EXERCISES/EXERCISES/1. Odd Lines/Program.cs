using System;
using System.IO;

namespace _1._OddLines
{
    public class Program
    {      
        public static void Main()
        {
           
            using (var reader = new StreamReader("CSharpAdvanced.txt"))
            {
                int lineNumber = 0;

                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null) break;

                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine($"{line}");
                    }

                    lineNumber++;
                }
            }
        }
    }
}