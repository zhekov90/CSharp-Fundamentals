using System;
using System.Linq;
using System.Text;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            StringBuilder output = new StringBuilder();
            foreach (string word in arr)
            {
                int count = word.Length;
                for (int i = 0; i < count; i++)
                {
                    output.Append(word);
                }
            }
            Console.WriteLine(output);
        }
    }
}
