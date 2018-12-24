using System;
using System.Linq;

namespace _3_Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> Checker = n => n[0] == n.ToUpper()[0];
            //Func<string, bool> Checker = n => char.IsUpper(n[0]);

            var words = Console.ReadLine()
               .Split(new string[] { " ", "."}, StringSplitOptions.RemoveEmptyEntries)
               .Where(Checker);

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
