using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hand1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> hand2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = hand1.Count;

            while (true)
            {
                if (hand1[0] > hand2[0])
                {
                    hand1.Add(hand1[0]);
                    hand1.Add(hand2[0]);
                }
                else if (hand1[0] < hand2[0])
                {
                    hand2.Add(hand2[0]);
                    hand2.Add(hand1[0]);
                }
                hand1.Remove(hand1[0]);
                hand2.Remove(hand2[0]);

                if (hand1.Count == 0)
                {
                    int sum = hand2.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (hand2.Count == 0)
                {
                    int sum = hand1.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }

        }
    }
}
