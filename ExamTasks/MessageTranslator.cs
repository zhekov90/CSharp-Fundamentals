using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[A-Za-z]{8,})]$";

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();
                Match match = Regex.Match(text, pattern);
                if (match.Success)
                {
                    string command = match.Groups["command"].Value;
                    string message = match.Groups["message"].Value;
                    List<int> list = new List<int>();
                    foreach (int letter in message)
                    {
                        list.Add(letter);
                    }

                    Console.Write($"{command}: ");
                    Console.WriteLine(string.Join(" ", list));
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}

