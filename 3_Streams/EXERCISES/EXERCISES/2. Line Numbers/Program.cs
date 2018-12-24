using System;
using System.IO;

namespace _2._LineNumbers
{
    public class Program
    {      
        public static void Main()
        {
            
            using (var reader = new StreamReader($"text.txt"))
            {
                using (var writer = new StreamWriter($"output.txt"))
                {
                    int lineNumbers = 0;

                    while (true)
                    {
                        string line = reader.ReadLine();

                        if (line == null) break;

                        writer.WriteLine($"Line {++lineNumbers}: {line}");
                    }
                }
            }
        }
    }
}
