using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> statusPirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> statusWarship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHP = int.Parse(Console.ReadLine());
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "Retire")
            {
                if (command[0] == "Fire")
                {
                    int index = int.Parse(command[1]);
                    int damage = int.Parse(command[2]);
                    if (index>=0 && index<statusWarship.Count)
                    {
                        statusWarship[index] -= damage;
                        if (statusWarship[index] <=0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (command[0] == "Defend")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int damage = int.Parse(command[3]);

                    if (startIndex>=0 && startIndex<statusPirateShip.Count && endIndex>=0 && endIndex<statusPirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            statusPirateShip[i] -= damage;
                            if (statusPirateShip[i]<=0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (command[0] == "Repair")
                {
                    int index = int.Parse(command[1]);
                    int health = int.Parse(command[2]);
                    if (index>=0 && index<statusPirateShip.Count)
                    {
                        statusPirateShip[index] += health;
                        if (statusPirateShip[index]>maxHP)
                        {
                            statusPirateShip[index] = maxHP;
                        }
                    }
                }
                else if (command[0] == "Status")
                {
                    int count = 0;
                    for (int i = 0; i < statusPirateShip.Count; i++)
                    {
                        int section = statusPirateShip[i];
                        if (section<maxHP*0.2)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }

                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine($"Pirate ship status: {statusPirateShip.Sum()}");
            Console.WriteLine($"Warship status: {statusWarship.Sum()}");
        }
    }
}
