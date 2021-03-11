using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy_Squad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "Print")
            {
                if (command[0] == "Join")
                {
                    list.Add(command[1]);
                }
                else if (command[0] == "Jump")
                {
                    if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) <= list.Count - 1)
                    {
                        list.Insert(int.Parse(command[2]), command[1]);
                    }
                }
                else if (command[0] == "Dive")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= list.Count - 1)
                    {
                        list.RemoveAt(int.Parse(command[1]));
                    }
                }
                else if (command[0] == "First" || command[0] == "Last")
                {
                    int count = int.Parse(command[1]);
                    if (command[0] == "First")
                    {
                        if (count > list.Count)
                        {
                            Console.WriteLine(string.Join(" ", list));
                        }
                        else
                        {
                            PrintFirst(list, count);
                        }
                    }
                    if (command[0] == "Last")
                    {
                        if (count > list.Count)
                        {
                            Console.WriteLine(string.Join(" ", list));
                        }
                        else
                        {
                            PrintLast(list, count);
                        }
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            if (command[0] == "Print")
            {
                PrintList(list, command);
            }
        }

        private static void PrintLast(List<string> list, int count)
        {
            for (int i = ((list.Count) - count); i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
        }

        private static void PrintFirst(List<string> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
        }

        private static void PrintList(List<string> list, string[] command)
        {
            if (command[1] == "Normal")
            {
                PrintNormal(list);
            }
            else if (command[1] == "Reversed")
            {
                PrintReversed(list);
            }
        }

        private static void PrintReversed(List<string> list)
        {
            list.Reverse();
            Console.Write("Frogs: ");
            Console.Write(string.Join(" ", list));
            Console.WriteLine();
        }

        private static void PrintNormal(List<string> list)
        {
            Console.Write("Frogs: ");
            Console.Write(string.Join(" ", list));
            Console.WriteLine();
        }
    }
}
