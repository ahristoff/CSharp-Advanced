using System;
using System.Linq;

namespace _2_Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new char[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().ToArray();
            }

            var count = 0;

            while (true)
            {
               
                var attackNumber = 0;
                var newRow = 0;
                var newCol = 0;

                for (int row = 0; row < matrix.Length; row++)
                {

                    for (int col = 0; col < matrix[row].Length; col++)
                    {

                        if (matrix[row][col] == 'K')
                        {
                            var currAttackNumber = findAttackNumbers(matrix, row, col);

                            if (attackNumber < currAttackNumber)
                            {
                                attackNumber = currAttackNumber;
                                newRow = row;
                                newCol = col;
                            }
                        }
                    }
                }

                matrix[newRow][newCol] = 'O';

                if (attackNumber == 0)
                {
                    break;
                }

                count++;
            }

            Console.WriteLine(count);         
        }

        private static int findAttackNumbers(char[][] matrix, int row, int col)
        {
            int count = 0;

            try
            {
                //1
                if (matrix[row - 2][col - 1] == 'K')
                {                   
                    count++;
                }
            }
            catch
            {
            }

            try
            {
                //2
                if (matrix[row - 2][col + 1] == 'K')
                {                   
                    count++;
                }
            }
            catch
            {
            }

            try
            {
                //3
                if (matrix[row - 1][col - 2] == 'K')
                {
                    count++;
                }
            }
            catch
            {
            }

            try
            {
                //4
                if (matrix[row - 1][col + 2] == 'K')
                {
                    count++;
                }
            }
            catch
            {
            }

            try
            {
                //5
                if (matrix[row + 1][col - 2] == 'K')
                {
                    count++;
                }
            }
            catch
            {
            }
          
            try
            { 
                //6
                if (matrix[row + 1][col + 2] == 'K')
                {
                    count++;
                }
            }
            catch
            {
            }

            try
            {
                //7
                if (matrix[row + 2][col - 1] == 'K')
                {
                    count++;
                }
            }
            catch
            {
            }

            try
            {
                //8
                if (matrix[row + 2][col + 1] == 'K')
                {
                    count++;
                }
            }
            catch
            {
            }

            return count;
        }
    }
}
