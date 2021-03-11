using System;

namespace NikuldensCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            string specialWord = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] commandInfo = command.Split();

                string action = commandInfo[0];

                if (action == "Replace")
                {
                    string currentChar = commandInfo[1];
                    string newChar = commandInfo[2];

                    specialWord = specialWord.Replace(currentChar, newChar);

                    Console.WriteLine(specialWord);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);

                    if (startIndex < 0 || startIndex >= specialWord.Length
                            || endIndex < 0 || endIndex >= specialWord.Length)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        specialWord = specialWord.Substring(0, startIndex)
                            + specialWord.Substring(endIndex + 1);

                        Console.WriteLine(specialWord);
                    }
                }
                else if (action == "Make")
                {
                    string subAction = commandInfo[1];

                    if (subAction == "Upper")
                    {
                        specialWord = specialWord.ToUpper();
                    }
                    else
                    {
                        specialWord = specialWord.ToLower();
                    }

                    Console.WriteLine(specialWord);
                }
                else if (action == "Check")
                {
                    string targetString = commandInfo[1];

                    if (specialWord.Contains(targetString))
                    {
                        Console.WriteLine($"Message contains {targetString}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {targetString}");
                    }
                }
                else if (action == "Sum")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);

                    if (startIndex < 0 || startIndex >= specialWord.Length
                            || endIndex < 0 || endIndex >= specialWord.Length)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        int sum = 0;

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            sum += specialWord[i];
                        }

                        Console.WriteLine(sum);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
