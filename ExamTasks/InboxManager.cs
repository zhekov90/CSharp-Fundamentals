using System;
using System.Collections.Generic;
using System.Linq;

namespace Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string[] command = Console.ReadLine().Split("->").ToArray();
            while (command[0]!= "Statistics")
            {
                if (command[0]=="Add")
                {
                    string username = command[1];
                    if (!dict.ContainsKey(username))
                    {
                        dict[username] = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    
                }
                else if (command[0] == "Send")
                {
                    string username = command[1];
                    string email = command[2];
                    dict[username].Add(email);
                }
                else if (command[0] == "Delete")
                {
                    string username = command[1];
                    if (!dict.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                    else
                    {
                        dict.Remove(username);
                    }
                }
                command = Console.ReadLine().Split("->").ToArray();

            }
            Console.WriteLine($"Users count: {dict.Keys.Count}");
            foreach (var person in dict.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine(person.Key);
                foreach (var email in person.Value)
                {
                    Console.WriteLine($" - {email}");
                }
            }
        }
    }
}
