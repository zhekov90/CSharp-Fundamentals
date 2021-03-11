using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine().Split("|").ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "Yohoho!")
            {
                if (command[0]=="Loot")
                {
                    for (int i = 1; i < command.Count; i++)
                    {
                        if (!loot.Contains(command[i]))
                        {
                            loot.Insert(0, command[i]);
                        }
                    }
                }
                else if (command[0] == "Drop")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < loot.Count)
                    {
                        string temp = loot[index];
                        loot.RemoveAt(index);
                        loot.Add(temp);
                    }
                }
                else if (command[0] == "Steal")
                {
                    int count = int.Parse(command[1]);
                    if (count>loot.Count)
                    {
                        count = loot.Count;
                    }
                    loot.Reverse();
                    List<string> removedLoot = new List<string>();
                    for (int i = 0; i < count; i++)
                    {
                        removedLoot.Add(loot[0]);
                        loot.RemoveAt(0);
                    }
                    loot.Reverse();
                    removedLoot.Reverse();
                    Console.WriteLine(string.Join(", ", removedLoot));
                }



                command = Console.ReadLine().Split().ToList();
            }
            if (loot.Count==0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double totalSum = 0;
                for (int i = 0; i < loot.Count; i++)
                {
                    totalSum += loot[i].Length;
                }
                totalSum /= loot.Count;
                Console.WriteLine($"Average treasure gain: {totalSum:f2} pirate credits.");
            }
           
        }
    }
}
