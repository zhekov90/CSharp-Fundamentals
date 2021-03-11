using System;
using System.Linq;

namespace Number_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(' ')
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string command = input.Split(" ")[0];

                if (command == "Switch")
                {
                    int index = int.Parse(input.Split(" ")[1]);
                    if (index >= 0 && index < list.Count)
                    {
                        int number = list[index];
                        list[index] = number - (number * 2);
                    }

                }
                else if (command == "Change")
                {
                    int index = int.Parse(input.Split(" ")[1]);
                    int value = int.Parse(input.Split(" ")[2]);

                    if (index >= 0 && index < list.Count)
                    {
                        list[index] = value;
                    }
                }
                else if (command == "Sum")
                {
                    string commandType = input.Split(" ")[1];
                    if (commandType == "Negative")
                    {

                        Console.WriteLine(list.Where(x => x < 0).Sum());
                    }
                    else if (commandType == "Positive")
                    {
                        Console.WriteLine(list.Where(x => x >= 0).Sum());
                    }
                    else if (commandType == "All")
                    {
                        Console.WriteLine(list.Sum());
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list.Where(x => x >= 0)));
        }
    }
}
