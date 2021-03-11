using System;
using System.Text;

namespace String_Manipulator___Group_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] splitted = command.Split();
                if (splitted[0]=="Translate")
                {
                    var letter = char.Parse(splitted[1]);
                    char replacement = char.Parse(splitted[2]);

                    for (int i = 0; i < text.Length; i++)
                    {
                        text = text.Replace(letter, replacement);
                    }
                    Console.WriteLine(text);
                }
                else if (splitted[0] == "Includes")
                {
                    string check = splitted[1];
                    if (text.Contains(check))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (splitted[0] == "Start")
                {
                    string start = splitted[1];
                    if (text.StartsWith(start))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (splitted[0] == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (splitted[0] == "FindIndex")
                {
                    string charToBeIndexed = splitted[1];
                    int index = text.LastIndexOf(charToBeIndexed);
                    Console.WriteLine(index);
                }
                else if (splitted[0] == "Remove")
                {
                    int startIndex = int.Parse(splitted[1]);
                    int count = int.Parse(splitted[2]);
                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }


                command = Console.ReadLine();
            }
        }
    }
}
