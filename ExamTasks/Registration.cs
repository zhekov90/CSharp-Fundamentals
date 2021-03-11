using System;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string pattern = @"^U\$(?<name>[A-Z][a-z]{2,})U\$P@\$(?<pass>\w{5,}\d)P@\$$";
            int successful = 0;
            for (int i = 0; i < number; i++)
            {
                string line = Console.ReadLine();
                Match match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string pass = match.Groups["pass"].Value;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {name}, Password: {pass}");

                    successful++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {successful}");
        }
    }
}
