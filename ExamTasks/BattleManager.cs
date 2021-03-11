using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(":");
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            while (command[0]!="Results")
            {
                
               
                if (command[0]=="Add")
                {
                    string name = command[1];
                    int health = int.Parse(command[2]);
                    int energy = int.Parse(command[3]);

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new List<int>());
                        dict[name].Add(health);
                        dict[name].Add(energy);
                    }
                    else
                    {
                        dict[name][0] += health;
                    }
                }
                else if (command[0] == "Attack")
                {
                    string attacker = command[1];
                    string defender = command[2];
                    int damage = int.Parse(command[3]);

                    if (dict.ContainsKey(attacker) && dict.ContainsKey(defender))
                    {
                        dict[defender][0] -= damage;
                        if (dict[defender][0]<=0)
                        {
                            Console.WriteLine($"{defender} was disqualified!");
                            dict.Remove(defender);
                        }
                        dict[attacker][1]--;
                        if (dict[attacker][1] == 0)
                        {
                            Console.WriteLine($"{attacker} was disqualified!");
                            dict.Remove(attacker);
                        }
                    }
                }
                else if (command[0] == "Delete")
                {
                    string name = command[1];
                    if (name=="All")
                    {
                        dict.Clear();
                    }
                    else if (dict.ContainsKey(name))
                    {
                        dict.Remove(name);
                    }
                }

                command = Console.ReadLine().Split(":");
            }

            Console.WriteLine($"People count: {dict.Count}");
            foreach (var person in dict.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{person.Key} - {person.Value[0]} - {person.Value[1]}");
            }
        }
    }
}
