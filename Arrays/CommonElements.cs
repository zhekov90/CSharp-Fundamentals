using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();
            string result = "";
            foreach (var word1 in arrTwo)
            {
                foreach (var word2 in arrOne)
                {
                    if (word1==word2)
                    {
                        result += word1 + " ";
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
