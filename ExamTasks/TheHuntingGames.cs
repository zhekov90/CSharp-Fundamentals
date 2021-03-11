using System;

namespace The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double dailyWaterPerPerson = double.Parse(Console.ReadLine());
            double dailyFoodPerPerson = double.Parse(Console.ReadLine());
            double totalWater = days * players * dailyWaterPerPerson;
            double totalFood = days * players * dailyFoodPerPerson;
            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;
                if (groupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    return;
                }
                if (i % 2 == 0)
                {
                    groupEnergy *= 1.05;
                    totalWater *= 0.70;
                }
                if (i % 3 == 0)
                {
                    groupEnergy *= 1.1;
                    totalFood = totalFood - (totalFood / players);
                }
            }
            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }

        }
    }
}
