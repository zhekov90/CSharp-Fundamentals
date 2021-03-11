using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, double>();
            string[] players = Console.ReadLine()
                .Split(", ");
            foreach (string player in players)
            {
                if (!dict.ContainsKey(player))
                {
                    dict[player] = 0;
                }
            }

            while (true)
            {
                string text = Console.ReadLine();
                string name = string.Empty;
                double distance = 0;
                if (text == "end of race")
                {
                    break;
                }
                else
                {
                    Regex regex = new Regex(@"[A-Za-z]");
                    MatchCollection matches = regex.Matches(text);

                    foreach (Match match in matches)
                    {
                        name += match.Value;
                    }
                    if (dict.ContainsKey(name))
                    {
                        MatchCollection matchesForDistance = Regex.Matches(text, @"[0-9]");

                        foreach (Match item in matchesForDistance)
                        {
                            distance += double.Parse(item.Value);
                        }
                        dict[name] += distance;
                    }
                }
            }
            dict = dict
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            var result = dict.OrderByDescending(x => x.Value).Take(3).ToList();
            for (int i = 1; i <= result.Count; i++)
            {
                string place = i == 1 ? "st" : i == 2 ? "nd" : "rd";
                Console.WriteLine($"{i}{place} place: {result[i - 1].Key}");
            }
        }
    }
}
