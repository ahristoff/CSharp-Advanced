using System;
using System.Linq;

namespace _1_Dangerous_Floor
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new char[8][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(',').Select(char.Parse).ToArray();
            }

            var command = Console.ReadLine();

            while (command != "END")
            {
                var piece = command[0];
                var startrow = int.Parse(command[1].ToString());
                var startcol = int.Parse(command[2].ToString());
                var endrow = int.Parse(command[4].ToString());
                var endcol = int.Parse(command[5].ToString());

                if (piece == 'K')
                {                 
                    King(matrix, startrow, startcol, endrow, endcol);                  
                }

                else if (piece == 'P')
                {
                    Pawn(matrix, startrow, startcol, endrow, endcol);                  
                }

                else if (piece == 'R')
                {
                    Rook(matrix, startrow, startcol, endrow, endcol);                   
                }

                else if (piece == 'B')
                {
                    Bishop(matrix, startrow, startcol, endrow, endcol);                
                }

                else if (piece == 'Q')
                {
                    Queen(matrix, startrow, startcol, endrow, endcol);                 
                }

                command = Console.ReadLine();
            }        
        }

        private static void Queen(char[][] matrix, int startrow, int startcol, int endrow, int endcol)
        {
            if (matrix[startrow][startcol] != 'Q')
            {
                Console.WriteLine("There is no such a piece!");
            }

            try
            {
                var a = 0;

                for (int i = 1; i < matrix.Length; i++)
                {

                    if (endrow == startrow + i && endcol == startcol + i || endrow == startrow + i && endcol == startcol - i || endcol == startcol - i && endrow == startrow - i || endcol == startcol + i && endrow == startrow - i || endrow == startrow && endcol == startcol + i || endrow == startrow && endcol == startcol - i || endcol == startcol && endrow == startrow + i || endcol == startcol && endrow == startrow - i)
                    {
                        matrix[endrow][endcol] = matrix[startrow][startcol];
                        matrix[startrow][startcol] = 'x';

                        a = 1;
                        break;
                    }
                }

                if(a == 0)
                {
                    matrix[endrow][endcol] = matrix[endrow][endcol];
                    Console.WriteLine("Invalid move!");
                }
            }

            catch
            {
                Console.WriteLine("Move go out of board!");
            }
        }

        private static void Bishop(char[][] matrix, int startrow, int startcol, int endrow, int endcol)
        {
            if (matrix[startrow][startcol] != 'B')
            {
                Console.WriteLine("There is no such a piece!");
            }

            try
            {
                var a = 0;

                for (int i = 1; i < matrix.Length; i++)
                {
                    if (endrow == startrow + i && endcol == startcol + i || endrow == startrow + i && endcol == startcol - i || endcol == startcol - i && endrow == startrow - i || endcol == startcol + i && endrow == startrow - i)
                    {
                        matrix[endrow][endcol] = matrix[startrow][startcol];
                        matrix[startrow][startcol] = 'x';

                        a = 1;
                        break;
                    }
                }

                if (a == 0)
                {
                    matrix[endrow][endcol] = matrix[endrow][endcol];
                    Console.WriteLine("Invalid move!");
                }
            }

            catch
            {
                Console.WriteLine("Move go out of board!");
            }
        }

        private static void Rook(char[][] matrix, int startrow, int startcol, int endrow, int endcol)
        {

            if (matrix[startrow][startcol] != 'R')
            {
                Console.WriteLine("There is no such a piece!");
            }

            try
            {
                var a = 0;

                for (int i = 0; i < matrix.Length; i++)
                {
                    if (endrow == startrow && endcol == startcol + i || endrow == startrow && endcol == startcol - i || endcol == startcol && endrow == startrow + i || endcol == startcol && endrow == startrow - i)
                    {
                        matrix[endrow][endcol] = matrix[startrow][startcol];
                        matrix[startrow][startcol] = 'x';

                        a = 1;
                        break;
                    }
                }

                if (a == 0)
                {
                    matrix[endrow][endcol] = matrix[endrow][endcol];
                    Console.WriteLine("Invalid move!");
                }
            }

            catch
            {
                Console.WriteLine("Move go out of board!");
            }
        }

        private static void Pawn(char[][] matrix, int startrow, int startcol, int endrow, int endcol)
        {

            if (matrix[startrow][startcol] != 'P')
            {
                Console.WriteLine("There is no such a piece!");
            }

            try
            {

                if (endrow == startrow - 1 && endcol == startcol)
                {
                    matrix[endrow][endcol] = matrix[startrow][startcol];
                    matrix[startrow][startcol] = 'x';
                }

                else
                {
                    matrix[endrow][endcol] = matrix[endrow][endcol];
                    Console.WriteLine("Invalid move!");
                }
            }

            catch
            {
                Console.WriteLine("Move go out of board!");
            }
        }

        private static void King(char[][] matrix, int startrow, int startcol, int endrow, int endcol)
        {
            if (matrix[startrow][startcol] != 'K')
            {
                Console.WriteLine("There is no such a piece!");
            }

            try
            {
                if ((endrow == startrow && endcol == startcol - 1) || (endrow == startrow && endcol == startcol + 1) || (endrow == startrow - 1 && endcol == startcol) || (endrow == startrow + 1 && endcol == startcol) || (endrow == startrow - 1 && endcol == startcol - 1) || (endrow == startrow - 1 && endcol == startcol + 1) || (endrow == startrow + 1 && endcol == startcol - 1) || (endrow == startrow + 1 && endcol == startcol + 1))
                {
                    matrix[endrow][endcol] = matrix[startrow][startcol];
                    matrix[startrow][startcol] = 'x';
                }

                else
                {
                    matrix[endrow][endcol] = matrix[endrow][endcol];
                    Console.WriteLine("Invalid move!");
                }
            }

            catch
            {
                Console.WriteLine("Move go out of board!");
            }
        }
    }
}
