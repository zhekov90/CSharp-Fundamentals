using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] arr = Console.ReadLine()
                .Split()
                .Where(x=> x.Length%2==0)
                .ToArray();
            foreach (var word in arr)
            {
                Console.WriteLine(word);
            }
        }
    }
}
