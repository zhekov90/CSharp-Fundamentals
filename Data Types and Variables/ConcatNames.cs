﻿using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOne = Console.ReadLine();
            string nameTwo = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.Write($"{nameOne}{delimiter}{nameTwo}");
            Console.WriteLine();
        }
    }
}
