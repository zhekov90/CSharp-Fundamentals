﻿using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine()) +30;
            if (min > 59)
            {
                hours = hours + 1;
                min = min - 60;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{min:D2}");
        }
    }
}
