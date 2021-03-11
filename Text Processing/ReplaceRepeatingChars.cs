using System;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string output = RemoveDuplicates(text);
            Console.WriteLine(output);
        }
        public static string RemoveDuplicates(string input)
        {
            string sResult = string.Empty;
            char cTemp = '\0';
            foreach (char cItem in input)
            {
                if (cItem != cTemp)
                {
                    sResult += cItem;
                }
                cTemp = cItem;
            }
            return sResult;
        }
    }
}
