using System;
using System.Collections.Generic;
using System.Linq;

namespace Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            int blacklistedCount = 0;
            int lostCount = 0;
            string parameter1 = string.Empty;
            string parameter2 = string.Empty;
            while (true)
            {
                string command = Console.ReadLine();
                List<string> commandArray = command.Split().ToList();
                command = commandArray[0];

                if (command == "Report")
                {
                    foreach (var name in input)
                    {
                        if (name == "Blacklisted")
                            blacklistedCount++;
                        if (name == "Lost")
                            lostCount++;
                    }
                    Console.WriteLine($"Blacklisted names: {blacklistedCount}");
                    Console.WriteLine($"Lost names: {lostCount}");
                    Console.WriteLine(string.Join(" ", input));
                    break;
                }
                if (commandArray.Count > 1)
                    parameter1 = commandArray[1];
                if (commandArray.Count > 2)
                {
                    parameter2 = commandArray[2];
                }
                switch (command)
                {
                    case "Blacklist":
                        if (input.IndexOf(parameter1) != -1)
                        {
                            input[input.IndexOf(parameter1)] = "Blacklisted";
                            Console.WriteLine($"{parameter1} was blacklisted.");
                        }
                        else
                        {
                            Console.WriteLine($"{parameter1} was not found.");
                        }
                        break;
                    case "Error":
                        if (input[int.Parse(parameter1)] != "Blacklisted" &&
                            input[int.Parse(parameter1)] != "Lost")
                        {
                            Console.WriteLine($"{input[int.Parse(parameter1)]} was lost due to an error.");
                            input[int.Parse(parameter1)] = "Lost";
                        }
                        break;
                    case "Change":
                        if (int.Parse(parameter1) < input.Count)
                        {
                            Console.WriteLine($"{input[int.Parse(parameter1)]} changed his username to {parameter2}.");
                            input[int.Parse(parameter1)] = parameter2;
                        }
                        break;
                }

            }
        }
    }
}
