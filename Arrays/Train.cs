using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            string output = string.Empty;
            int sum = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                output+=($"{wagons[i]} ");
                sum += wagons[i];
            }
            Console.WriteLine(output);
            Console.WriteLine(sum);
        }
    }
}
