using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|").Reverse().ToList();
            var result = new List<string>();
            foreach (var item in input)
            {
                List<string> nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
