using System;
using System.Collections.Generic;
using System.Linq;

namespace _912_String_Matrix_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(new string[] { "(", ")" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var gradus = int.Parse(command[1]);

            var list = GetInput();    
            
            PrintList(ManipulateList(gradus, list));
          
        }

        private static List<string> ManipulateList(int com, List<string> list)
        {
            CompleteList(list);

            var newList = new List<string>();

            if (com % 360 == 0)
            {
                newList = CompleteList(list);
            }

            if (com % 360 == 90)
            {
                var queue = new Queue<char>();

                for (int j = 0; j < MaxLength(list); j++)
                {

                    for (int i = 0; i < list.Count; i++)
                    {
                        queue.Enqueue(list[i][j]);
                    }
                }

                for (int i = 0; i < MaxLength(list); i++)
                {
                    string str = null;

                    for (int j = 0; j < list.Count; j++)
                    {
                        str = str + queue.Dequeue();
                    }

                    var charString = str.Reverse().ToArray();
                    var resultstring = new string(charString);
                    newList.Add(resultstring);
                }
            }

            if (com % 360 == 180)
            {               
                list.Reverse();
                
                for (int i = 0; i < list.Count; i++)
                {
                    var charString = list[i].Reverse().ToArray();
                    var resultstring = new string(charString);
                                     
                    newList.Add(resultstring);
                }
            }

            if (com % 360 == 270)
            {
                var stack = new Stack<char>();
               
                for (int j = 0; j < MaxLength(list); j++)
                {

                    for (int i = 0; i < list.Count; i++)
                    {
                        stack.Push(list[i][j]);
                    }
                }

                for (int i = 0; i < MaxLength(list); i++)
                {
                    string str = null;

                    for (int j = 0; j < list.Count; j++)
                    {
                        str = str + stack.Pop();
                    }

                    var chaSstr = str.Reverse().ToArray();
                    var resultString = new string(chaSstr);

                    newList.Add(resultString);
                }
            }
            
            return newList;               
        }

        private static List<string> CompleteList(List<string> list)
        {
            MaxLength(list);
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Count() < MaxLength(list))
                {
                    list[i] = list[i] + new string(' ', MaxLength(list) - list[i].Count());
                }
            }

            return list;
        }

        private static int MaxLength(List<string> list)
        {
            var maxLenght = 0;

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].Count() > maxLenght)
                {
                    maxLenght = list[i].Count();
                }
            }

            return maxLenght;
        }

        private static void PrintList(List<string> list)
        {
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }

        private static List<string> GetInput()
        {
            var list = new List<string>();  
            
            var input = Console.ReadLine();

            while (input != "END")
            {
                list.Add(input);

                input = Console.ReadLine();
            }

            return list;
        }
    }
}
