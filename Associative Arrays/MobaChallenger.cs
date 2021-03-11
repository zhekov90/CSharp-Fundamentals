using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" ");
            Dictionary<string, Dictionary<string, int>> playerPool = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> skillPoints = new Dictionary<string, int>();
            while (command[0] != "Season")
            {
                if (command.Contains("->"))
                {

                    string player = command[0];
                    string position = command[2];
                    int skill = int.Parse(command[4]);

                    if (!playerPool.ContainsKey(player))
                    {
                        playerPool[player] = new Dictionary<string, int>();
                        playerPool[player].Add(position, skill);
                        if (!skillPoints.ContainsKey(player))
                        {
                            skillPoints.Add(player, skill);
                        }
                        else
                        {
                            skillPoints[player] += skill;
                        }

                    }
                    else
                    {

                        if (playerPool[player].ContainsKey(position))
                        {
                            if (playerPool[player][position] < skill)
                            {
                                playerPool[player][position] = skill;
                            }
                            skillPoints[player] += skill;
                        }
                        else
                        {
                            playerPool[player].Add(position, skill);
                            skillPoints[player] += skill;
                        }
                    }
                }
                else if (command.Contains("vs"))
                {
                    string player1 = command[0];
                    string player2 = command[2];
                    if (playerPool.ContainsKey(player1) && playerPool.ContainsKey(player2))
                    {
                        foreach (var position1 in playerPool[player1].Keys)
                        {
                            foreach (var position2 in playerPool[player2].Keys)
                            {
                                if (position1 == position2)
                                {
                                    if (playerPool[player1][position1] < playerPool[player2][position2])
                                    {
                                        playerPool.Remove(player1);
                                    }
                                    else if (playerPool[player1][position1] > playerPool[player2][position2])
                                    {
                                        playerPool.Remove(player2);
                                    }
                                    else
                                    {
                                        continue;
                                    }

                                }
                            }
                        }
                    }
                }

                command = Console.ReadLine().Split(" ");
            }

            foreach (var person in playerPool.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{person.Key}: {person.Value.Values.Sum()} skill");
                foreach (var pair in person.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {pair.Key} <::> {pair.Value}");
                }
            }
        }
    }
}
