using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_Sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string[] text = Console.ReadLine().Split("->").ToArray();
            while (text[0]!="END")
            {
                if (text[0] == "Add")
                {
                    string road = text[1];
                    string racer = text[2];
                    if (!dict.ContainsKey(road))
                    {
                        dict[road] = new List<string>();
                    }
                    dict[road].Add(racer);
                }
                else if (text[0] == "Move")
                {
                    string currentRoad = text[1];
                    string racer = text[2];
                    string nextRoad = text[3];

                    if (dict.ContainsKey(currentRoad) && dict[currentRoad].Contains(racer))
                    {
                        dict[currentRoad].Remove(racer);
                        dict[nextRoad].Add(racer);
                    }
                }
                else if (text[0] == "Close")
                {
                    string road = text[1];
                    dict.Remove(road);
                }


                text = Console.ReadLine().Split("->").ToArray();
            }
            Console.WriteLine("Practice sessions:");
            foreach (var road in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(road.Key);
                foreach (var racer in road.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }


        }
    }
}
