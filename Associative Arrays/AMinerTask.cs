using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string resource = "";
            int quantity = 0;

            for (int i = 1; ; i++)
            {
                if (i % 2 != 0)
                {
                    resource = Console.ReadLine();

                }
                if (i % 2 == 0)
                {
                    quantity = int.Parse(Console.ReadLine());
                }
                if (resource.Equals("stop"))
                {
                    break;
                }

                if (!dict.ContainsKey(resource))
                {
                    dict.Add(resource, 0);

                }
                dict[resource] += quantity;
                quantity = 0;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
