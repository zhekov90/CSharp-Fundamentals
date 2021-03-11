using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double dailyPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 1; i <= days; i++)
            {
                total += dailyPlunder;

                if (i%3==0)
                {
                   total+= dailyPlunder * 0.50;
                }
                if (i%5==0)
                {
                    total *= 0.70;
                }
            }
            if (total>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {total:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {total/expectedPlunder*100:f2}% of the plunder.");
            }


        }
    }
}
