using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();
            string[] decoder = Console.ReadLine().Split().ToArray();
            StringBuilder result = new StringBuilder();
            bool isValid = false;
            for (int i = 0; i < encrypted.Length; i++)
            {
                int letter = encrypted[i];
                if (letter >= 100 && letter <= 125 || letter == 35)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (!isValid)
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
            else
            {
                for (int i = 0; i < encrypted.Length; i++)
                {
                    int letter = encrypted[i];
                    letter -= 3;
                    result.Append((char)letter);
                }
                result = result.Replace(decoder[0], decoder[1]);
                Console.WriteLine(result);
            }
        }
    }
}
