﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count / 2; i++)
            {
                Console.Write(list[i] + list[list.Count - 1 - i] + " ");

            }
            if (list.Count % 2 == 1)
            {
                Console.Write(list[list.Count / 2]);
            }
            Console.WriteLine();
        }
    }
}
