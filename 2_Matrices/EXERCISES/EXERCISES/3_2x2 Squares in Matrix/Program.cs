using System;
using System.Linq;

namespace _3_2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new string[input[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split().ToArray();
            }

            int count = 0;

            for (int row = 0; row < matrix.Length - 1; row++)
            {

                for (int col = 0; col < matrix[row].Length - 1; col++)
                {

                    if (matrix[row][col] == matrix[row][col + 1] && matrix[row][col] == matrix[row + 1][col] && matrix[row][col] == matrix[row + 1][col + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
