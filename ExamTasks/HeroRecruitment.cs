using System;
using System.Collections.Generic;
using System.Linq;

namespace Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();

            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();
            while (command[0] != "End")
            {
                string action = command[0];
                string name = command[1];

                if (action == "Enroll")
                {
                    if (!heroes.ContainsKey(name))
                    {
                        heroes[name] = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already enrolled.");
                    }
                }
                else if (command[0] == "Learn")
                {
                    string spell = command[2];
                    if (!heroes.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                    else
                    {
                        if (heroes[name].Contains(spell))
                        {
                            Console.WriteLine($"{name} has already learnt {spell}.");
                        }
                        else
                        {
                            heroes[name].Add(spell);
                        }
                    }
                }
                else if (command[0] == "Unlearn")
                {
                    string spell = command[2];
                    if (!heroes.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                    else
                    {
                        if (!heroes[name].Contains(spell))
                        {
                            Console.WriteLine($"{name} doesn't know {spell}.");
                        }
                        else
                        {
                            heroes[name].Remove(spell);
                        }
                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine("Heroes:");

            foreach (var hero in heroes.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (hero.Key != null)
                {
                    Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
                }
            }
        }
    }
}
