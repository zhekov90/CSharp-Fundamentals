using System;
using System.Collections.Generic;
using System.Linq;

namespace Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("#").ToList();
            int water = int.Parse(Console.ReadLine());
            double effort = 0;
            int totalFire = 0;
            List<string> putOutCells = new List<string>();
            
                for (int i = 0; i < input.Count; i++)
                {
                    List<string> line = input[i].Split(" = ").ToList();
                    string type = line[0];
                    int value = int.Parse(line[1]);
                    if (water>=value)
                    {
                        if (type == "High" && value >= 81 && value <= 125)
                        {
                            water -= value;
                            effort += value * 0.25;
                            totalFire += value;
                            putOutCells.Add(line[1]);
                        }
                        else if (type == "Medium" && value >= 51 && value <= 80)
                        {
                            water -= value;
                            effort += value * 0.25;
                            totalFire += value;
                            putOutCells.Add(line[1]);
                        }
                        else if (type == "Low" && value >= 1 && value <= 50)
                        {
                            water -= value;
                            effort += value * 0.25;
                            totalFire += value;
                            putOutCells.Add(line[1]);
                        }
                        
                    }
                   
                }

            Console.WriteLine("Cells:");
            for (int i = 0; i < putOutCells.Count; i++)
            {
                Console.WriteLine($" - {putOutCells[i]}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
