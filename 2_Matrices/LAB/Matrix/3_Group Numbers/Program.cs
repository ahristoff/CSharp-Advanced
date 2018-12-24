using System;
using System.Linq;

namespace _3_Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new String[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
         
            int[] sizes = new int[3];

            foreach (var x in numbers) 
            {
                int remainder = Math.Abs(x) % 3;
                sizes[remainder]++;
            }

            int[][] matrix =     
            {
              new int[sizes[0]],
              new int[sizes[1]],
              new int[sizes[2]]
            };
                    
            int index0 = 0;
            int index1 = 0;
            int index2 = 0;

            foreach (var x in numbers)
            {
                if (Math.Abs(x) % 3 == 0)
                {
                    matrix[Math.Abs(x) % 3][index0] = x;
                    index0++;
                }
                if (Math.Abs(x) % 3 == 1)
                {
                    matrix[Math.Abs(x) % 3][index1] = x;
                    index1++;
                }
                if (Math.Abs(x) % 3 == 2)
                {
                    matrix[Math.Abs(x) % 3][index2] = x;
                    index2++;
                }
            }

            foreach (var x in matrix)
            {
                Console.WriteLine(string.Join(" ", x));
            }        
        }
    }
}
