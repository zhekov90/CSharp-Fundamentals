using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    int passengers = int.Parse(command[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengersToFit = int.Parse(command[0]);
                    for (int i = 0; i <= wagons.Count - 1; i++)
                    {
                        if (wagons[i] + passengersToFit <= maxCapacity)
                        {
                            wagons[i] += passengersToFit;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));


        }
    }
}
