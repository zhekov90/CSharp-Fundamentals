using System;

namespace Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double budget = 0;
            for (int i = 1; i <= months; i++)
            {
                int currentMonth = i;
                if (currentMonth==1)
                {
                    budget += tripPrice * 0.25;
                    continue;
                }
                if (currentMonth%4==0)
                {
                    budget *= 1.25;
                }
                if (currentMonth%2==1 && currentMonth!=1)
                {
                    budget *= 0.84;
                }

                budget += tripPrice * 0.25;
            }
            if (budget>=tripPrice)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {budget-tripPrice:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {tripPrice-budget:f2}lv. more.");
            }
        }
    }
}
