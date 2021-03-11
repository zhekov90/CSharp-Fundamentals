using System;

namespace Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string output = string.Empty;
            string reversedOutput = string.Empty;

            for (int i = 1; i <= 3; i++)
            {
                string command = Console.ReadLine();
                if (i==3)
                {
                    output += ($"{command}");
                }

                else
                {
                    output += ($"{command} ");
                }
                
                
            }
            for (int j = output.Length-1; j >=0; j--)
            {
                reversedOutput += output[j];
            }
            Console.WriteLine(reversedOutput);
        }
    }
}
