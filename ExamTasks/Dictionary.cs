using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            string[] commandArr = command.Split(" | ");

            for (int j = 0; j < commandArr.Length; j++)
            {
                string[] resultArr = commandArr[j].Split(": ");

                if (!(words.ContainsKey(resultArr[0])))
                {
                    words.Add(resultArr[0], new List<string>());
                }
                words[resultArr[0]].Add(resultArr[1]);
            }


            string[] checkArr1 = Console.ReadLine().Split(" | ");

            for (int i = 0; i < checkArr1.Length; i++)
            {
                string currentWord = checkArr1[i];

                if (words.ContainsKey(currentWord))
                {
                    foreach (var word in words.OrderBy(x => x.Key).Where(x => x.Key == currentWord))
                    {
                        Console.WriteLine($"{word.Key}");

                        foreach (var item in word.Value.OrderByDescending(x => x.Length))
                        {
                            Console.WriteLine($" -{item}");
                        }
                    }
                }
            }

            string checkArr = Console.ReadLine();


            if (checkArr == "List")
            {
                string[] orderedDict = words.OrderBy(x => x.Key).Select(x => x.Key).ToArray();

                Console.WriteLine(string.Join(" ", orderedDict));
            }

        }
    }
}
