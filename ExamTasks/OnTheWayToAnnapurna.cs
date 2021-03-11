using System;
using System.Collections.Generic;
using System.Linq;

namespace On_the_Way_to_Annapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split("->");
            while (input[0] != "END")
            {
                string command = input[0];
                string store = input[1];


                if (command == "Add")
                {
                    string items = input[2];
                    if (!dict.ContainsKey(store))
                    {
                        dict[store] = new List<string>();
                    }
                    if (items.Length == 1)
                    {
                        string itemToAdd = input[2];

                            dict[store].Add(itemToAdd);
                    }
                    else if (items.Length > 1)
                    {
                        string[] itemsToAdd = input[2].Split(",");
                        foreach (var item in itemsToAdd)
                        {
                            dict[store].Add(item);
                        }
                    }
                }
                else if (command == "Remove")
                {
                    if (dict.ContainsKey(store))
                    {
                        dict.Remove(store);
                    }
                }

                input = Console.ReadLine().Split("->");
            }
            Console.WriteLine($"Stores list:");
            foreach (var store in dict.OrderByDescending(x => x.Value.Count).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine(store.Key);
                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }

        }
    }
}
