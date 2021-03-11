using System;
using System.Linq;

namespace String_Manipulator___Group_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            
            while (input!="Done")
            {
                string[] command = input.Split().ToArray();
                if (command[0]=="Change")
                {
                    char oldChar = char.Parse(command[1]);
                    char replacement = char.Parse(command[2]);
                    text = text.Replace(oldChar, replacement);
                    Console.WriteLine(text);
                }
                else if (command[0] == "Includes")
                {
                    string partToCheck = command[1];
                    if (text.Contains(partToCheck))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command[0] == "End")
                {
                    string endPartToCheck = command[1];
                    
                    if (text.EndsWith(endPartToCheck))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                    
                }
                else if (command[0] == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command[0] == "FindIndex")
                {
                    char charToFind = char.Parse(command[1]);
                    int index = text.IndexOf(charToFind);
                    Console.WriteLine(index);
                }
                else if (command[0] == "Cut")
                {
                    int startIndex = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    if (startIndex>=0 && length>0 && length<text.Length)
                    {
                        text = text.Substring(startIndex, length);
                        Console.WriteLine(text);
                    }
                    
                }



                input = Console.ReadLine();
            }
        }
    }
}
