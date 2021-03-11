using System;
using System.Text.RegularExpressions;

namespace Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^.*([\@|\*])(?<first>[A-Z][a-z]{2,})\1:\s\[(?<second>\w{1})\]\|\[(?<third>\w{1})\]\|\[(?<fourth>\w{1})\]\|$";

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();
                Match match = Regex.Match(text, pattern);
                if (match.Success)
                {

                    string first = match.Groups["first"].Value;
                    int second = char.Parse(match.Groups["second"].Value);
                    int third = char.Parse(match.Groups["third"].Value);
                    int fourth = char.Parse(match.Groups["fourth"].Value);

                    Console.WriteLine($"{first}: {second} {third} {fourth}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }

            }
        }
    }
}
