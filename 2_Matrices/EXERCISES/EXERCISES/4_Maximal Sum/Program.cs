using System;
using System.Linq;

namespace _4_Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new int[input[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split().Take(input[1]).Select(int.Parse).ToArray();
            }

            var maxSum = int.MinValue;
            var maxRow = 0;
            var maxCol = 0;

            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    var currSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] + matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if (maxSum < currSum)
                    {
                        maxSum = currSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            Console.WriteLine($"{matrix[maxRow][maxCol]} {matrix[maxRow][maxCol+1]} {matrix[maxRow][maxCol+2]}\n{matrix[maxRow+1][maxCol]} {matrix[maxRow+1][maxCol+1]} {matrix[maxRow+1][maxCol+2]}\n{matrix[maxRow+2][maxCol]} {matrix[maxRow+2][maxCol+1]} {matrix[maxRow+2][maxCol+2]}");
        }
    }
}
