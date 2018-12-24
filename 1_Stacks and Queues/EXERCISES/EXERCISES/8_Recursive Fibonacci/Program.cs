using System;

namespace _8_Recursive_Fibonacci
{
    public class RecursiveFibonacci
    {
        
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            long n1 = 1;
            long n2 = 1;
            long sum = 0;

            for (int i = 2; i < n ; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;      
            }

            Console.WriteLine(n2);
        }     
    }
}

