using System;
using System.Text;
using System.Text.RegularExpressions;

namespace The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"([#$%*&])(?<name>[A-z]+)(\1)=(?<length>\d+)!!(?<code>.+)";
            string input = Console.ReadLine();
            while (true)
            {
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(input))
                {
                    string name = regex.Match(input).Groups["name"].Value;
                    int length = int.Parse(regex.Match(input).Groups["length"].Value);
                    string code = regex.Match(input).Groups["code"].Value;
                    if (length == code.Length)
                    {
                        StringBuilder result = new StringBuilder();
                        for (int i = 0; i < code.Length; i++)
                        {
                            char symbol = (char)(code[i] + length);
                            result.Append(symbol);
                        }
                        Console.WriteLine($"Coordinates found! {name} -> {result}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }

                input = Console.ReadLine();
            }

        }
    }
}
