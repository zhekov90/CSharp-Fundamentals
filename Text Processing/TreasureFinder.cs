using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();
            int counter = 0;
            while (text != "find")
            {
                if (text=="find")
                {
                    break;
                }
                string message = "";
                for (int i = 0; i < text.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        j += counter;
                        if (j==key.Length)
                        {
                            j = 0;
                            counter = 0;
                        }
                       int letter =  text[i];
                        
                        letter -= key[j];
                        message+= (char)letter;
                        counter++;
                        break;
                    }
                }
                string treasure = message.Substring(message.IndexOf('&') + 1, message.LastIndexOf('&') - message.IndexOf('&')-1); 
                string coordinates = message.Substring(message.IndexOf('<') + 1, message.IndexOf('>') - message.IndexOf('<') - 1);

                Console.WriteLine($"Found {treasure} at {coordinates}");
                counter = 0;
                text = Console.ReadLine();
            }
        }
    }
}
