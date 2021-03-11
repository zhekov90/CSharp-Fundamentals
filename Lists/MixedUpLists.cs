using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> line2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> rule = new List<int>();
            List<int> maxList = new List<int>();
            List<int> mixedList = new List<int>();
            if (line1.Count > line2.Count)
            {
                maxList = line1;
            }
            else
            {
                maxList = line2;
                maxList.Reverse();
            }
            for (int i = maxList.Count - 2; i < maxList.Count; i++)
            {
                rule.Add(maxList[i]);
            }
            rule.Sort();
            if (line1.Count > line2.Count)
            {
                line1.RemoveRange(line1.Count - 2, 2);
                line2.Reverse();
            }
            else
            {
                line2.RemoveRange(line2.Count - 2, 2);
                line2.Reverse();
            }
            for (int i = 0; i < line1.Count; i++)
            {
                mixedList.Add(line1[i]);
                mixedList.Add(line2[i]);
            }
            List<int> output = mixedList.FindAll(x => x > rule[0] && x < rule[1]);
            output.Sort();
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
