using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isChanged = false;

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "end")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(command[1]);
                        numbers.Add(numberToAdd);
                        isChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(command[1]);
                        numbers.Remove(numberToRemove);
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        int numberToRemoveAt = int.Parse(command[1]);
                        numbers.RemoveAt(numberToRemoveAt);
                        isChanged = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(command[1]);
                        int indexToInsert = int.Parse(command[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        isChanged = true;
                        break;


                    case "Contains":
                        int numberContained = int.Parse(command[1]);
                        bool check = numbers.Contains(numberContained);
                        if (check)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int currentNum = numbers[i];
                            if (currentNum % 2 == 0)
                            {
                                Console.Write($"{currentNum} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int currentNum = numbers[i];
                            if (currentNum % 2 == 1)
                            {
                                Console.Write($"{currentNum} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        int numberToFilter = int.Parse(command[2]);
                        switch (command[1])
                        {
                            case "<":
                                Console.WriteLine(string.Join(" ", numbers.Where(x => x < numberToFilter)));
                                break;
                            case ">":
                                Console.WriteLine(string.Join(" ", numbers.Where(x => x > numberToFilter)));
                                break;
                            case ">=":
                                Console.WriteLine(string.Join(" ", numbers.Where(x => x >= numberToFilter)));
                                break;
                            case "<=":
                                Console.WriteLine(string.Join(" ", numbers.Where(x => x <= numberToFilter)));
                                break;
                        }
                        break;
                }
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
