using System;
using System.Collections.Generic;
using System.Linq;

namespace Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ownedTanks = Console.ReadLine().Split(", ").ToList();
            int commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                List<string> input = Console.ReadLine().Split(", ").ToList();

                if (input[0]=="Add")
                {
                    string tankName = input[1];
                    if (ownedTanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else
                    {
                        Console.WriteLine("Tank successfully bought");
                        ownedTanks.Add(tankName);
                    }
                }
                if (input[0] == "Remove")
                {
                    string tankName = input[1];
                    if (ownedTanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank successfully sold");
                        ownedTanks.Remove(tankName);
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");
                    }
                }
                if (input[0] == "Remove At")
                {
                    int index = int.Parse(input[1]);
                    if (index>=0 && index<ownedTanks.Count)
                    {
                        Console.WriteLine("Tank successfully sold");
                        ownedTanks.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                if (input[0] == "Insert")
                {
                    int index = int.Parse(input[1]);
                    string tankName = input[2];
                    if (index >= 0 && index < ownedTanks.Count)
                    {
                        if (ownedTanks.Contains(tankName))
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                        else
                        {
                            Console.WriteLine("Tank successfully bought");
                            ownedTanks.Insert(index, tankName);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", ownedTanks));
        }
    }
}
