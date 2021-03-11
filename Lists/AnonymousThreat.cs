using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];
                if (command == "3:1")
                {
                    break;
                }

                int start = int.Parse(commands[1]);
                int end = int.Parse(commands[2]);
                string concatWord = string.Empty;

                if (end > input.Count - 1 || end < 0)
                {
                    end = input.Count - 1;
                }

                if (start < 0 || start > input.Count)
                {
                    start = 0;
                }

                if (command == "merge")
                {
                    for (int i = start; i <= end; i++)
                    {
                        concatWord += input[i];
                    }
                    input.RemoveRange(start, end - start + 1);
                    input.Insert(start, concatWord);

                }

                else if (command == "divide")
                {
                    List<string> divided = new List<string>();
                    int divide = int.Parse(commands[2]);
                    string word = input[start];
                    input.RemoveAt(start);
                    int parts = word.Length / divide;
                    for (int i = 0; i < divide; i++)
                    {
                        if (i == divide - 1)
                        {
                            divided.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            divided.Add(word.Substring(i * parts, parts));
                        }
                    }
                    input.InsertRange(start, divided);
                }

            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}