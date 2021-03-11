using System;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < lines; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
