using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "end")
                {
                    break;
                }
                switch (command[0])
                {
                    case "Delete":
                        int numberToDelete = int.Parse(command[1]);
                        input.RemoveAll(item => item == numberToDelete);
                        break;
                    case "Insert":
                        input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }



    }
}
