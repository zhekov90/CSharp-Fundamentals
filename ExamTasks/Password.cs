using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(.+)>(?<numbers>\d{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<symbols>[^<>]{3})<\1$";
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < number; i++)
            {
                
                string text = Console.ReadLine();
                Match match = Regex.Match(text, pattern);
                if (match.Success)
                {
                    StringBuilder sb = new StringBuilder();
                    string numbers = match.Groups["numbers"].Value;
                    string lower = match.Groups["lower"].Value;
                    string upper = match.Groups["upper"].Value;
                    string symbols = match.Groups["symbols"].Value;
                    sb.Append(numbers);
                    sb.Append(lower);
                    sb.Append(upper);
                    sb.Append(symbols);
                    Console.WriteLine($"Password: {sb}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
            
        }
    }
}
