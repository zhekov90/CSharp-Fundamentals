using System;
using System.Text.RegularExpressions;

namespace Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string pattern = @"^\|(?<name>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#$";
            for (int i = 0; i < number; i++)
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string title = match.Groups["title"].Value;
                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                    
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
                if (i==number-1)
                {
                    break;
                }
                input = Console.ReadLine();
            }

        }
    }
}
