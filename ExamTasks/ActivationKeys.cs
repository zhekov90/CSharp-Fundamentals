using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] command = Console.ReadLine().Split(">>>");
            while (command[0]!="Generate")
            {
                if (command[0]== "Contains")
                {
                    string substring = command[1];
                    if (text.Contains(substring))
                    {
                        Console.WriteLine($"{text} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command[0] == "Flip")
                {
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);
                    if (command[1]=="Upper")
                    {
                        string part = text.Substring(startIndex, endIndex - startIndex);
                        string partToUpper = part.ToUpper();
                        text=text.Replace(part, partToUpper);
                        Console.WriteLine(text);
                    }
                    else if (command[1]=="Lower")
                    {
                        string part = text.Substring(startIndex,endIndex- startIndex);
                        string partToLower = part.ToLower();
                        text = text.Replace(part, partToLower);
                        Console.WriteLine(text);
                    }
                }
                else if (command[0] == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    string partToDelete = text.Substring(startIndex, endIndex - 1);
                    text = text.Remove(startIndex,endIndex-startIndex);
                    Console.WriteLine(text);
                }

                command = Console.ReadLine().Split(">>>");
            }
            Console.WriteLine($"Your activation key is: {text}");


        }
    }
}
