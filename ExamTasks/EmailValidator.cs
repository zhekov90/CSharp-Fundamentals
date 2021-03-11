using System;
using System.Collections.Generic;

namespace Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string line = Console.ReadLine();
            
            List<int> asciiString = new List<int>();
            while (line != "Complete")
            {
                string[] splitted = line.Split();
                string command = splitted[0];
                if (command=="Make")
                {
                    if (splitted[1]=="Upper")
                    {
                        email = email.ToUpper();
                        Console.WriteLine(email);
                    }
                    else if (splitted[1]=="Lower")
                    {
                        email = email.ToLower();
                        Console.WriteLine(email);
                    }
                }
                else if (command == "GetDomain")
                {
                    int count = int.Parse(splitted[1]);
                    for (int i = email.Length-count; i < email.Length; i++)
                    {
                        char currLetter = email[i];
                        Console.Write(currLetter);
                    }
                    Console.WriteLine();
                }
                else if (command == "GetUsername")
                {
                    int indexOfSymbol = email.IndexOf('@');
                    if (email.Contains('@'))
                    {
                        string username = email.Substring(0, indexOfSymbol);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol."); 
                    }
                }
                else if (command == "Replace")
                {
                    char charToReplace = char.Parse(splitted[1]);
                    char newChar = '-';
                   email= email.Replace(charToReplace, newChar);
                    Console.WriteLine(email);
                }
                else if (command == "Encrypt")
                {
                    for (int i = 0; i < email.Length; i++)
                    {
                        int currSymbol = email[i];
                        asciiString.Add(currSymbol);
                    }
                    Console.WriteLine(string.Join(" ", asciiString));
                }
                line = Console.ReadLine();
            }
        }
    }
}
