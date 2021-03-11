using System;

namespace Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceForKgFlour = double.Parse(Console.ReadLine());
            double priceForPackEggs = priceForKgFlour * 0.75;
            double priceForLiterMilk = priceForKgFlour * 1.25;
            double priceMilkForOneCozonac = priceForLiterMilk / 4;

            double priceForCozonac = priceForKgFlour + priceForPackEggs + priceMilkForOneCozonac;

            int countCozonacs = 0;
            int countEggs = 0;
            while (budget>=priceForCozonac)
            {
                countCozonacs++;
                countEggs += 3;
                if (countCozonacs%3==0)
                {
                    countEggs -= (countCozonacs - 2);
                }
                budget -= priceForCozonac;
            }
            Console.WriteLine($"You made {countCozonacs} cozonacs! Now you have {countEggs} eggs and {budget:f2}BGN left.");

        }
    }
}
