using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|").ToList();
            int health = 100;
            int bitcoins = 0;
            int bestRoom = 1;
            for (int i = 0; i < list.Count; i++)
            {
                List<string> line = list[i].Split().ToList();
                string command = line[0];
                int number = int.Parse(line[1]);

                if (command=="potion")
                {
                    
                        health += number;
                    if (health >= 100)
                    {
                        int healed = health-number;
                        int diff = 100 - healed;
                        health = 100;
                        Console.WriteLine($"You healed for {diff} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    bestRoom++;
                }

                 else if (command=="chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                    bestRoom++;
                }
                else
                {
                    health -= number;
                    if (health>0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                        bestRoom++;
                    }
                    else if (health<=0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        break;
                    }

                }

            }
            if (health>0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
           
           


        }
    }
}
