using System;
using System.Collections.Generic;
using System.Numerics;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();
            numberAsString = numberAsString.TrimStart(new char[] { '0' });
            char[] bigNum = numberAsString.ToCharArray();
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("0");
                return;
            }
            List<string> result = new List<string>();

            int parse = 0;
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                parse = (int.Parse(Convert.ToString(bigNum[i])) * number) + parse;
                result.Insert(0, (parse % 10).ToString());
                parse /= 10;
            }


            if (parse > 0)
                Console.WriteLine($"{parse}{string.Join("", result)}");
            else
                Console.WriteLine($"{string.Join("", result)}");
        }
    }
}

