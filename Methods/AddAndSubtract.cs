using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sumFirstTwo = SumNumbers(num1, num2);
            int result = SubtractThirdNumber(sumFirstTwo, num3);
            Console.WriteLine(result);
        }

        private static int SubtractThirdNumber(int sumFirstTwo, int num3)
        {
            return sumFirstTwo - num3;
            
        }

        private static int SumNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
