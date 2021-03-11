using System;
using System.Collections.Generic;
using System.Linq;

namespace Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();

            List<string> hand = new List<string>();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "Ready")
            {
                if (command[0] == "Add")
                {
                    if (cards.Contains(command[1]))
                    {
                        hand.Add(command[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command[0] == "Insert")
                {
                    string name = command[1];
                    int index = int.Parse(command[2]);
                    if (cards.Contains(name))
                    {
                        if (index < 0 || index > hand.Count - 1 || cards.IndexOf(name) == -1)
                        {
                            Console.WriteLine("Error!");
                        }
                        else
                        {
                            hand.Insert(index, name);

                        }
                    }
                    else
                    {
                        Console.WriteLine("Error!");

                    }

                }
                else if (command[0] == "Remove")
                {
                    if (hand.Contains(command[1]))
                    {
                        hand.Remove(command[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command[0] == "Swap")
                {

                    int card1 = hand.IndexOf(command[1]);
                    int card2 = hand.IndexOf(command[2]);
                    string temp = hand[card1];
                    hand[card1] = hand[card2];
                    hand[card2] = temp;

                }
                else if (command[0] == "Shuffle")
                {
                    hand.Reverse();
                }

                command = Console.ReadLine().Split().ToList();
            }
            if (command[0] == "Ready")
            {
                Console.WriteLine(string.Join(" ", hand));
            }
        }
    }
}
