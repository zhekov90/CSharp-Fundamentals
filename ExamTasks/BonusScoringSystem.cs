using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());
            double maxBonus = double.MinValue;
            int maxCounter = 0;
            for (int i = 0; i < students; i++)
            {
                if (students >= 0 && lectures >= 0 && bonus >= 0)
                {


                    int attendances = int.Parse(Console.ReadLine());
                    double totalBonus = (attendances / lectures)
               * (5 + bonus);

                    double currMax = totalBonus;

                    if (totalBonus >= maxBonus && maxBonus != currMax)
                    {
                        maxBonus = totalBonus;
                        maxCounter = attendances;
                    }
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxCounter} lectures.");
        }
    }
}
