using System;
using System.Linq;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();
            foreach (var bannedWord in bannedWords)
            {
                if (text.Contains(bannedWord))
                {
                    text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
