using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split("; ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandAndTime = new Dictionary<string, int>();
            int totalTime = 0;
            while (command[0] != "start of concert")
            {
                if (command[0] == "start of concert")
                {
                    break;
                }

                if (command[0] == "Add")
                {
                    string bandName = command[1];
                    string[] members = command[2].Split(", ");
                    foreach (var member in members)
                    {
                        if (!dict.ContainsKey(bandName))
                        {
                            dict[bandName] = new List<string>();
                        }
                        if (!dict[bandName].Contains(member))
                        {
                            dict[bandName].Add(member);
                        }

                    }
                }
                else if (command[0] == "Play")
                {
                    string bandName = command[1];
                    int time = int.Parse(command[2]);
                    totalTime += time;
                    if (!bandAndTime.ContainsKey(bandName))
                    {
                        bandAndTime.Add(bandName, time);
                    }
                    else
                    {
                        bandAndTime[bandName] += time;
                    }
                }


                command = Console.ReadLine().Split("; ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            if (command[0] == "start of concert")
            {
                Console.WriteLine($"Total time: {totalTime}");
                foreach (var time in bandAndTime.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{time.Key} -> {time.Value}");
                }
            }
            string finalLine = Console.ReadLine();
            
            if (dict.ContainsKey(finalLine))
            {
                Console.WriteLine(finalLine);
                foreach (var member in dict[finalLine])
                {
                    Console.WriteLine($"=> {member}");
                }
            }
            
        }



    }
}

