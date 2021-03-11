using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "Stop")
            {
                if (command[0] == "Stop")
                {
                    break;
                }
                if (command[0] == "Delete")
                {
                    int index = int.Parse(command[1])+1;
                    if (index >= 0 && index < words.Count)
                    {
                        words.RemoveAt(index);
                    }
                }
                else if (command[0] == "Swap")
                {
                    if (words.Contains(command[1]) && words.Contains(command[2]))
                    {
                        int indexFirst = words.IndexOf(command[1]);
                        int indexSecond = words.IndexOf(command[2]);

                        words[indexFirst] = command[2];
                        words[indexSecond] = command[1];
                    }
                }
                else if (command[0] == "Put")
                {
                    string word = command[1];
                    int index = int.Parse(command[2])-1;
                    if (index >= 0 && index <= words.Count)
                    {
                        words.Insert(index, word);
                    }

                }
                else if (command[0] == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                }
                else if (command[0] == "Replace")
                {
                    if (words.Contains(command[2]))
                    {
                        int firstIndex = words.IndexOf(command[2]);
                        words.RemoveAt(firstIndex);
                        words.Insert(firstIndex, command[1]);
                    }
                }

                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", words));


        }
    }
}
