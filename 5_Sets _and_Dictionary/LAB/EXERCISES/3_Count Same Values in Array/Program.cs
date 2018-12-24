using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse);

            var dict = new SortedDictionary<double, int>();

            foreach (var x in input)
            {             

                    if (!dict.ContainsKey(x))
                    {
                        dict.Add(x, 1);    //dict[x] = 1;
                    }

                    else
                    {
                        dict[x]++;
                    }              
            }          

            foreach (var x in dict)
            {
               var y =  x.Key.ToString();

                if (y.Contains("."))
                {
                    y = y.Replace(".", ",");
                }
               
                Console.WriteLine($"{y} - {x.Value} times");
            }
        }
    }
}
