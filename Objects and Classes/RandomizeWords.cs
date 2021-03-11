using System;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length-1; i++)
            {
                int index = random.Next(0, input.Length-1);
                string tempVar = input[index];
                input[index] = input[i];
                input[i] = tempVar;
               
            }
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
