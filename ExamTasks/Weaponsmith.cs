using System;
using System.Collections.Generic;
using System.Linq;

namespace Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> parts = Console.ReadLine().Split("|").ToList();
            List<string> command = Console.ReadLine().Split(" ").ToList();
            while (command[0]!="Done")
            {
                if (command[0]=="Move")
                {
                    int index = int.Parse(command[2]);
                    if (command[1]=="Left" && index!=0)
                    {
                        if (index>=0 && index<parts.Count)
                        {
                            string temp = parts[index];
                            parts[index] = parts[index-1];
                            parts[index-1] = temp;
                        }
                    }
                    else if (command[1]== "Right" && index!=parts.Count-1)
                    {
                        if (index >= 0 && index < parts.Count)
                        {
                            string temp = parts[index];
                            parts[index] = parts[index+1];
                            parts[index+1] = temp;
                        }
                    }
                }
                else if (command[0]=="Check")
                {
                    if (command[1] == "Even")
                    {
                        List<string> evenList = new List<string>();

                        for (int i = 0; i < parts.Count; i++)
                        {
                            if (i%2==0)
                            {
                                evenList.Add(parts[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ",evenList));
                    }
                    else if (command[1] == "Odd")
                    {
                        List<string> oddList = new List<string>();

                        for (int i = 0; i < parts.Count; i++)
                        {
                            if (i % 2 == 1)
                            {
                                oddList.Add(parts[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", oddList));
                    }
                }


                command = Console.ReadLine().Split(" ").ToList();
            }
            Console.WriteLine($"You crafted {(string.Join("", parts))}!");
        }
    }
}
