using System;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([\$|\%])(?<tag>[A-Z][a-z]{2,})\1:\s\[(?<first>\d+)\]\|\[(?<second>\d+)\]\|\[(?<third>\d+)\]\|$";

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();
                Match match = Regex.Match(text, pattern);
                if (match.Success)
                {
                    string tag = match.Groups["tag"].Value;
                    char first = (char)(int.Parse(match.Groups["first"].Value));
                    char second = (char)(int.Parse(match.Groups["second"].Value));
                    char third = (char)(int.Parse(match.Groups["third"].Value));
                    Console.WriteLine($"{tag}: {first}{second}{third}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
