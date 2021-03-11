using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            double volumeMax = double.MinValue;
            string currentModel = string.Empty;
            for (int i = 0; i < lines; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double volumeTwo = Math.PI * (double)radius * (double)radius * (double)height;
                if (volumeTwo>volumeMax)
                {
                    volumeMax = volumeTwo;
                    currentModel = model;
                }
            }
            Console.WriteLine(currentModel);
        }
    }
}
