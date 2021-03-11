using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tasks = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "End")
            {

                if (command[0] == "Complete")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < tasks.Count)
                    {
                        tasks[index] = 0;
                    }
                }
                else if (command[0] == "Change")
                {
                    int index = int.Parse(command[1]);
                    int time = int.Parse(command[2]);
                    if (index >= 0 && index < tasks.Count)
                    {
                        tasks[index] = time;
                    }
                }
                else if (command[0] == "Drop")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < tasks.Count)
                    {
                        tasks[index] = -1;
                    }
                }
                else if (command[0] == "Count")
                {
                    if (command[1] == "Completed")
                    {
                        int completedTasks = 0;
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            int current = tasks[i];
                            if (current == 0)
                            {
                                completedTasks++;
                            }
                        }
                        Console.WriteLine(completedTasks);
                    }
                    else if (command[1] == "Incomplete")
                    {
                        int incompletedTasks = 0;
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            int current = tasks[i];
                            if (current > 0)
                            {
                                incompletedTasks++;
                            }
                        }
                        Console.WriteLine(incompletedTasks);

                    }
                    else if (command[1] == "Dropped")
                    {
                        int droppedTasks = 0;
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            int current = tasks[i];
                            if (current < 0)
                            {
                                droppedTasks++;
                            }
                        }
                        Console.WriteLine(droppedTasks);
                    }
                }

                command = Console.ReadLine().Split().ToList();
            }
            List<int> result = new List<int>();
            for (int i = 0; i < tasks.Count; i++)
            {
                int current = tasks[i];
                if (current > 0)
                {
                    result.Add(current);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
