using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            double leftTime = 0;
            double rightTime = 0;
            for (int i = 0; i < list.Count / 2; i++)
            {
                left.Add(list[i]);
                leftTime += list[i];
                if (list[i] == 0)
                {
                    leftTime *= 0.8;
                }

            }
            for (int i = list.Count - 1; i > list.Count / 2; i--)
            {
                right.Add(list[i]);
                rightTime += list[i];
                if (list[i] == 0)
                {
                    rightTime *= 0.8;
                }
            }
            if (leftTime < rightTime)
            {
                string winner = "left";
                Console.WriteLine($"The winner is {winner} with total time: {leftTime}");
            }
            else if (rightTime < leftTime)
            {
                string winner = "right";
                Console.WriteLine($"The winner is {winner} with total time: {rightTime}");
            }

        }
    }
}
