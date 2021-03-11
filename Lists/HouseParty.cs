using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[2] != "not")
                {
                    if (guests.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                        continue;
                    }
                    else
                    {
                        guests.Add(command[0]);
                    }
                }
                else
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }

                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
