using System;

namespace Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededXp = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());
            double totalXp = 0;
            int counter = 0;
            for (int i = 1; i <= countOfBattles; i++)
            {
                double XpEarnedPerBattle = double.Parse(Console.ReadLine());
                if (i%3==0)
                {
                    XpEarnedPerBattle *= 1.15;
                }
                if (i%5==0)
                {
                    XpEarnedPerBattle *= 0.9;
                }
                totalXp += XpEarnedPerBattle;
                counter = i;
                if (totalXp >= neededXp)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {counter} battles.");
                    return;
                }

            }
            if (totalXp<neededXp)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededXp-totalXp:f2} more needed.");
            }
            
        }
    }
}
