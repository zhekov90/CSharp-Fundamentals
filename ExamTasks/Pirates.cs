using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] command = text.Split("||");
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            while (command[0] != "Sail")
            {
                string town = command[0];
                int people = int.Parse(command[1]);
                int gold = int.Parse(command[2]);
                if (!dict.ContainsKey(town))
                {
                    dict.Add(town, new List<int>());
                    dict[town].Add(people);
                    dict[town].Add(gold);
                }
                else
                {
                    dict[town][0] += people;
                    dict[town][1] += gold;
                }
                command = Console.ReadLine().Split("||");
            }
            command = Console.ReadLine().Split("=>");

            while (command[0] != "End")
            {
                if (command[0] == "Plunder")
                {
                    string town = command[1];
                    int people = int.Parse(command[2]);
                    int gold = int.Parse(command[3]);
                    dict[town][0] -= people;
                    dict[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (dict[town][0] == 0 || dict[town][1] == 0)
                    {
                        dict.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (command[0] == "Prosper")
                {
                    string town = command[1];
                    int gold = int.Parse(command[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else if(gold>0)
                    {
                        dict[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {dict[town][1]} gold.");
                    }
                }
                command = Console.ReadLine().Split("=>");
            }
            if (dict.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {dict.Count} wealthy settlements to go to:");
                foreach (var town in dict.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{town.Key} -> Population: {town.Value[0]} citizens, Gold: {town.Value[1]} kg");
                }
            }
        }
    }
}
