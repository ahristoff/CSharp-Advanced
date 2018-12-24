using System;
using System.Linq;

namespace _2_Crypto_Master
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var maxSequence = 0;

            for (int index = 0; index < numbers.Length; index++)
            {

                for (int step = 1; step < numbers.Length; step++)
                {
                    int currIndex = index;
                    int nextIndex = (index + step) % numbers.Length;
                    int currSequence = 1;

                    while (numbers[currIndex] < numbers[nextIndex])
                    {
                        currIndex = nextIndex;
                        nextIndex = (nextIndex + step) % numbers.Length;
                        currSequence++;
                    }

                    if (currSequence > maxSequence)
                    {
                        maxSequence = currSequence;
                    }
                }
            }

            Console.WriteLine(maxSequence);
        }
    }
}
