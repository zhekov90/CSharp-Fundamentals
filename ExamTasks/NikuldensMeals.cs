using System;
using System.Collections.Generic;
using System.Linq;

namespace Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string[] line = Console.ReadLine().Split("-");
            int unlikedMeals = 0;
            while (line[0] != "Stop")
            {
                string command = line[0];
                string guest = line[1];
                string meal = line[2];
                if (command == "Like")
                {
                    if (!dict.ContainsKey(guest))
                    {
                        dict[guest] = new List<string>();
                        dict[guest].Add(meal);
                    }
                    else if (dict.ContainsKey(guest) && !dict[guest].Contains(meal))
                    {
                        dict[guest].Add(meal);
                    }
                }
                else if (command == "Unlike")
                {
                    if (!dict.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (!dict[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        dict[guest].Remove(meal);
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        unlikedMeals++;
                    }

                }
                line = Console.ReadLine().Split("-").ToArray();
            }
            foreach (var person in dict
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{person.Key}: {string.Join(", ", person.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}
