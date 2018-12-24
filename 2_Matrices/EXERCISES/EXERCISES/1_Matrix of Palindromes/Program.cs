using System;
using System.Linq;

namespace _1_Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new string[input[0]][];

            for (int row = 0; row < matrix.Length; row++)   
            {
                matrix[row] = new string[input[1]];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = alphabet[row].ToString() + alphabet[col + row].ToString() + alphabet[row].ToString();
                }
            }
            
            foreach (var x in matrix)
            {
                Console.WriteLine(string.Join(" ", x));
            }
        }
    }
}
