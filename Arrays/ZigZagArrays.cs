using System;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arrOne = new string[n];
            string[] arrTwo = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] current = Console.ReadLine().Split();
                if (i%2==0)
                {
                    arrOne[i] = current[0];
                    arrTwo[i] = current[1];
                }
                else
                {
                    arrOne[i] = current[1];
                    arrTwo[i] = current[0];
                }
                
            }
            Console.WriteLine(string.Join(" ", arrOne));
            Console.WriteLine(string.Join(" ", arrTwo));
        }
    }
}
