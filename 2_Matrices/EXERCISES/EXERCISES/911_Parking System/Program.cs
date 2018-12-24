using System;
using System.Linq;

namespace _911_Parking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = GetMatrix();

            var command = Console.ReadLine();

            while (command != "stop")
            {
                var com = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                var initialRow = com[0];
                var parkSpotRow = com[1];
                var parkSpotCol = com[2];

                var distance = 0;

                if (matrix[parkSpotRow][parkSpotCol] == 0)
                {
                    matrix[parkSpotRow][parkSpotCol] = 1;

                    distance = Math.Abs(initialRow - parkSpotRow) + 1 + Math.Abs(parkSpotCol);

                    Console.WriteLine(distance);
                }

                else if (matrix[parkSpotRow][parkSpotCol] == 1)
                {
                    int countBusyBackplace = 0;

                    for (int i = 1; i < parkSpotCol; i++)
                    {
                        if (matrix[parkSpotRow][parkSpotCol - i] == 0)
                        {
                            matrix[parkSpotRow][parkSpotCol - i] = 1;
                            distance = Math.Abs(initialRow - parkSpotRow) + 1 + Math.Abs(i - parkSpotCol);

                            Console.WriteLine(distance);
                            break;
                        }

                        else
                        {
                            countBusyBackplace++;
                        }
                    }

                    if (countBusyBackplace == parkSpotCol - 1)
                    {
                        int countBusyFrontplace = 0;

                        for (int i = 1; i <= matrix.Length - parkSpotCol - 1; i++)
                        {
                            if (matrix[parkSpotRow][parkSpotCol + i] == 0)
                            {
                                matrix[parkSpotRow][parkSpotCol + i] = 1;
                                distance = Math.Abs(initialRow - parkSpotRow) + 1 + Math.Abs(i + parkSpotCol);

                                Console.WriteLine(distance);
                                break;
                            }

                            else
                            {
                                countBusyFrontplace++;
                            }
                        }

                        if (countBusyFrontplace == matrix.Length - parkSpotCol - 1)
                        {
                            Console.WriteLine($"Row {parkSpotRow} full");
                        }
                    }
                }

                command = Console.ReadLine();
            }
        }

        private static int[][] GetMatrix()
        {
            var matrixSize = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var matrix = new int[matrixSize[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[matrixSize[1]];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = 0;
                }
            }

            return matrix;
        }
    }
}
