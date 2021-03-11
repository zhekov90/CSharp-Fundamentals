using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            while (startingYield>=100)
            {
                counter++;
                sum += startingYield-26;
                startingYield -= 10;
            }
            if (sum!=0)
            {
                sum -= 26;
            }
            Console.WriteLine(counter);
            Console.WriteLine(sum);
        }
    }
}
