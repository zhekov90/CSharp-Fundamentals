using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<name>[A-Za-z0-9\!\@\#\$\?]+)\=(?<length>\d+)\<\<(?<message>.+)$";

            string text = Console.ReadLine();
            while (text!="Last note")
            {
                Match match = Regex.Match(text, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    StringBuilder nameToPrint = new StringBuilder();
                    int length = int.Parse(match.Groups["length"].Value);
                    string message = match.Groups["message"].Value;
                    if (length==message.Length)
                    {
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (name[i]!='!' && name[i] != '@' && name[i] != '#' && name[i] != '$' && name[i] != '?')
                            {
                                nameToPrint.Append(name[i]);
                            }
                        }
                        Console.WriteLine($"Coordinates found! {nameToPrint} -> {message}");
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


                text = Console.ReadLine();
            }


        }
    }
}
