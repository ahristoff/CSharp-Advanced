using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split().ToList();
            var input2 = Console.ReadLine().Split().ToList();

            var queue1 = new Queue<string>(input1);
            var queue2 = new Queue<string>(input2);

            var turns = 0;
            var result = 0;

            while (true)
            {
                var first = queue1.Dequeue();
                var second = queue2.Dequeue();

                turns++;

                if (turns >= 1_000_000)
                {
                    EndGame(queue1, queue2, turns);
                }

                if (int.Parse(first.Substring(0, first.Length - 1)) > int.Parse(second.Substring(0, second.Length - 1)))
                {
                    result = FirstHandGreaterSecondHand(queue1, queue2, first, second);

                    if (result != 0)
                    {
                        break;
                    }
                }

                else if (int.Parse(first.Substring(0, first.Length - 1)) < int.Parse(second.Substring(0, second.Length - 1)))
                {
                    result = SecondHandGreaterFirstHand(queue1, queue2, first, second);

                    if (result != 0)
                    {
                        break;
                    }
                }

                else
                {
                    result = SecondHandEqualFirstHand(queue1, queue2, first, second);

                    if (result != 0)
                    {
                        break;
                    }
                }
            }

            EndResult(result, turns);
        }

        private static int SecondHandEqualFirstHand(Queue<string> queue1, Queue<string> queue2, string first, string second)
        {
            var list = new List<string>();

            int result = 0;
            list.Add(first);
            list.Add(second);

            while (true)
            {
                result = IsValidByDraw(queue2.Count, queue1.Count);

                if (result != 0)
                {
                    break;
                }

                var fir1 = queue1.Dequeue();
                var sec1 = queue2.Dequeue();
                var fir2 = queue1.Dequeue();
                var sec2 = queue2.Dequeue();
                var fir3 = queue1.Dequeue();
                var sec3 = queue2.Dequeue();

                list.Add(fir1);
                list.Add(fir2);
                list.Add(fir3);
                list.Add(sec1);
                list.Add(sec2);
                list.Add(sec3);

                var sortedList = list.OrderByDescending(n => int.Parse(n.Substring(0, n.Length - 1))).ToList();

                var fs1 = (int)char.Parse(fir1.Substring(fir1.Length - 1)) - 96;
                var fs2 = (int)char.Parse(fir2.Substring(fir2.Length - 1)) - 96;
                var fs3 = (int)char.Parse(fir3.Substring(fir3.Length - 1)) - 96;

                var sumFirst = fs1 + fs2 + fs3;

                var sc1 = (int)char.Parse(sec1.Substring(sec1.Length - 1)) - 96;
                var sc2 = (int)char.Parse(sec2.Substring(sec2.Length - 1)) - 96;
                var sc3 = (int)char.Parse(sec3.Substring(sec3.Length - 1)) - 96;

                var sumSecond = sc1 + sc2 + sc3;

                if (sumFirst > sumSecond)
                {

                    for (int i = 0; i < sortedList.Count; i++)
                    {
                        queue1.Enqueue(sortedList[i]);
                    }

                    break;
                }

                else if (sumFirst < sumSecond)
                {

                    for (int i = 0; i < sortedList.Count; i++)
                    {
                        queue2.Enqueue(sortedList[i]);
                    }

                    break;
                }
            }

            result = IsValid(queue1.Count, queue2.Count);
            return result;
        }

        private static void EndResult(int result, int turns)
        {
            if (result == 1)
            {
                Console.WriteLine($"First player wins after {turns} turns");
            }

            else if (result == 2)
            {
                Console.WriteLine($"Second player wins after {turns} turns");
            }

            else if (result == 3)
            {
                Console.WriteLine($"Draw after {turns} turns");
            }
        }

        private static int SecondHandGreaterFirstHand(Queue<string> queue1, Queue<string> queue2, string first, string second)
        {
            queue2.Enqueue(second);
            queue2.Enqueue(first);

            var result = IsValid(queue1.Count, queue2.Count);


            return result;
        }

        private static int FirstHandGreaterSecondHand(Queue<string> queue1, Queue<string> queue2, string first, string second)
        {
            queue1.Enqueue(first);
            queue1.Enqueue(second);

            var result = IsValid(queue1.Count, queue2.Count);
            return result;
        }

        private static void EndGame(Queue<string> queue1, Queue<string> queue2, int turns)
        {
            if (queue1.Count > queue2.Count)
            {
                Console.WriteLine($"First player wins after {turns} turns");
                return;
            }

            else if (queue2.Count > queue1.Count)
            {
                Console.WriteLine($"Second player wins after {turns} turns");
                return;
            }

            else
            {
                Console.WriteLine($"Draw after {turns} turns");
                return;
            }
        }

        private static int IsValidByDraw(int count1, int count2)
        {
            if (count1 < 3 && count2 < 3)
            {
                return 3;
            }

            else if (count1 < 3 && count2 >= 3)
            {
                return 2;
            }

            else if (count1 >= 3 && count2 < 3)
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }

        private static int IsValid(int count1, int count2)
        {

            if (count1 == 0 && count2 == 0)
            {
                return 3;
            }

            else if (count1 == 0 && count2 > 0)
            {
                return 2;
            }

            else if (count1 > 0 && count2 == 0)
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }
    }
}
