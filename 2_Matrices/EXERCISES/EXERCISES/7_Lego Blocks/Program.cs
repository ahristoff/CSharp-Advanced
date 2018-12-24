using System;
using System.Linq;

namespace _7_Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var jaggedLeft = GetMattrix(n);
            var jaggedRight = GetMattrix(n);

            CompareJagged(jaggedRight, jaggedLeft, n);

            PrintMatrix(jaggedRight, jaggedLeft, n);                                      
        }

        private static void PrintMatrix(int[][] jaggedRight, int[][] jaggedLeft, int n)
        {

            if (CompareJagged(jaggedRight, jaggedLeft, n) == -1)
            {
                var rows = jaggedLeft.Length;
                var joinedMatrix = new int[rows][];

                for (int row = 0; row < rows; row++)
                {
                    joinedMatrix[row] = jaggedLeft[row].Concat(jaggedRight[row].Reverse()).ToArray();
                }

                foreach (var x in joinedMatrix)
                {
                    Console.WriteLine($"[{string.Join(", ", x)}]");
                }
            }

            else
            {
                Console.WriteLine($"The total number of cells is: {CompareJagged(jaggedRight, jaggedLeft, n)}");
            }
        }

        private static int CompareJagged(int[][] jaggedRight, int[][] jaggedLeft, int n)
        {
            var jaggedLenght = jaggedRight[0].Length + jaggedLeft[0].Length;
            var count = 0;
            var totalLenght = jaggedLenght;

            for (int i = 1; i < n; i++)
            {
                var RowJaggedLenght = jaggedRight[i].Length + jaggedLeft[i].Length;
                totalLenght += RowJaggedLenght;

                if (jaggedLenght == RowJaggedLenght)
                {
                    count++;
                }
            }

            if (count == n - 1)
            {
                return -1;
            }

            else
            {
                return totalLenght;
            }
        }
      
        private static int[][] GetMattrix(int n)
        {
            var jagged = new int[n][];

            for (int row = 0; row < n; row++)
            {
                jagged[row] = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            return jagged;
        }
    }
}
