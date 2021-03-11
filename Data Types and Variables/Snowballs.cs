using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger maxQuality = 0;
            BigInteger maxSnow = 0;
            BigInteger maxTime = 0;
            BigInteger maxValue = 0;
            for (BigInteger i = 0; i < n; i++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballQuality = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), (int)snowballQuality);
                if (snowballValue>=maxValue)
                {
                    maxSnow = snowballSnow;
                    maxQuality = snowballQuality;
                    maxTime = snowballTime;
                    maxValue = snowballValue;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}
  
