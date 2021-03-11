using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int nDividedByTwo = n / 2;
            int counter = 0;
            while (n>=m)
            {
                n -= m;
                counter++;
                if (n==nDividedByTwo && y!=0)
                {
                    n /= y;
                }
            }
            if (n<m)
            {
                Console.WriteLine(n);
                Console.WriteLine(counter);
            }
        }
    }
}
