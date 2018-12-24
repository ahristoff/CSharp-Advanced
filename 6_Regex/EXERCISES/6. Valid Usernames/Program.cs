using System;
using System.Text.RegularExpressions;

namespace _6._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"^[\w-]{3,12}$";    
            
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
