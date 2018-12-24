using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new int[n][];

            for (int row = 0; row < matrix.Length; row++)      
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            var sumLeftDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                sumLeftDiagonal += matrix[i][i];
            }

            var sumRightDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                sumRightDiagonal += matrix[i][n - i - 1];
            }

            int totalSum = sumLeftDiagonal - sumRightDiagonal;

            Console.WriteLine(Math.Abs(totalSum));
        }
    }
}
