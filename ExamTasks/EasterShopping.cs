using System;
using System.Collections.Generic;
using System.Linq;

namespace Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0]=="Include")
                {
                    string shop = command[1];
                    list.Add(shop);
                }
                else if (command[0] == "Visit")
                {
                    int numberOfShops = int.Parse(command[2]);
                    if (command[1]=="first" && numberOfShops<=list.Count)
                    {
                        for (int j   = 0; j < numberOfShops; j++)
                        {
                            list.RemoveAt(0);
                        }
                        
                    }
                    else if (command[1]== "last" && numberOfShops <= list.Count)
                    {
                        for (int k = 0; k < numberOfShops; k++)
                        {
                            list.RemoveAt(list.Count - 1);
                        }
                        
                    }
                }
                else if (command[0] == "Prefer")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    if (index1>=0 && index1<list.Count && index2 >= 0 && index2 < list.Count)
                    {
                        string temp = list[index1];
                        list[index1] = list[index2];
                        list[index2] = temp;
                    }
                }
                else if (command[0] == "Place")
                {
                    int index = int.Parse(command[2]);
                    if (index>=0 && index+1<list.Count)
                    {
                        list.Insert(index + 1, command[1]);
                    }
                }

            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
