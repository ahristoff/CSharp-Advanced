using System;
using System.Text.RegularExpressions;

namespace _7._Valid_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"(([0-1][0-2]?\:[0-5][0-9]?\:[0-5][0-9]?\sAM)|([12][0-9]?\:[0-5][0-9]?\:[0-5][0-9]?\sPM))";

            while (text != "END")
            {
                var regex = new Regex(pattern, RegexOptions.Multiline);
                var match = regex.Match(text);

                if (match.Success)
                {                    
                    Console.WriteLine("valid");                                        
                }

                else
                {
                    Console.WriteLine("invalid");
                }

                text = Console.ReadLine();
            }
        }
    }
}
