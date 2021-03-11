using System;
using System.Collections.Generic;
using System.Linq;

namespace Contact_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while (true)
            {


                if (command[0] == "Export" && command.Count == 1)
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    string contact = command[1];
                    int index = int.Parse(command[2]);
                    if (!list.Contains(contact))
                    {
                        list.Add(contact);
                    }
                    else if (list.Contains(contact) && index >= 0 && index <= list.Count)
                    {
                        list.Insert(index, contact);
                    }

                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index <= list.Count)
                    {
                        list.RemoveAt(index);
                    }
                }
                else if (command[0] == "Export")
                {
                    int startIndex = int.Parse(command[1]);
                    int count = int.Parse(command[2]);
                    if (count <= list.Count)
                    {
                        for (int i = startIndex; i < count; i++)
                        {
                            Console.Write(list[i] + " ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = startIndex; i < list.Count; i++)
                        {
                            Console.Write(list[i] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                if (command[0] == "Print")
                {
                    if (command[1] == "Normal")
                    {
                        Console.WriteLine($"Contacts: {string.Join(" ", list)}");
                    }
                    else if (command[1] == "Reversed")
                    {
                        list.Reverse();
                        Console.WriteLine($"Contacts: {string.Join(" ", list)}");
                    }
                    break;
                }
                command = Console.ReadLine().Split().ToList();

            }

        }
    }
}
