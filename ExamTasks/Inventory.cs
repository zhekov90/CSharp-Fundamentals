using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            List<string> command = Console.ReadLine().Split(" - ").ToList();
            while (command[0]!="Craft!")
            {
                if (command[0]=="Collect")
                {

                    if (!list.Contains(command[1]))
                    {
                        list.Add(command[1]);
                    }
                }
                else if (command[0] == "Drop")
                {
                    if (list.Contains(command[1]))
                    {
                        list.Remove(command[1]);
                    }
                }
                else if (command[0] == "Combine Items")
                {
                    List<string> items = command[1].Split(":").ToList();
                    if (list.Contains(items[0]))
                    {
                        int currIndex = list.IndexOf(items[0]) +1;
                        list.Insert(currIndex, items[1]);
                    }
                }
                else if (command[0] == "Renew")
                {
                    if (list.Contains(command[1]))
                    {
                        string temp = command[1];
                        list.Remove(command[1]);
                        list.Add(temp);
                       
                    }
                }



                command = Console.ReadLine().Split(" - ").ToList();
            }
            if (command[0]=="Craft!")
            {
                Console.WriteLine(string.Join(", ", list));
            }

        }
    }
}
