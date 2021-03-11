using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonyms.ContainsKey(word))
                {
                    synonyms[word] = new List<string>();
                }

                synonyms[word].Add(synonym);
                
                
            }
            foreach (var item in synonyms)
            {
                Console.Write($"{item.Key} - {string.Join(", ",item.Value)}");
                Console.WriteLine();
            }
           
        }
    }
}
