using System;

namespace Biscuits_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competingFactory = int.Parse(Console.ReadLine());
            int totalBiscuits = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i%3==0)
                {
                   totalBiscuits+= (int)Math.Floor(biscuitsPerDay*workers*0.75);
                }
                else
                {
                    totalBiscuits += biscuitsPerDay * workers;
                }
               
            }
            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
            double diff = competingFactory - totalBiscuits;
            double percentage = diff/competingFactory * 100;
            if (percentage<0)
            {
                Console.WriteLine($"You produce {Math.Abs(percentage):f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {Math.Abs(percentage):f2} percent less biscuits.");
            }
            
        }
    }
}
