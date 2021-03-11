using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToArray();
            StringBuilder encrypted = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i].ToString();
                for (int j = 0; j < word.Length; j++)
                {
                    int letter = word[j];
                    letter += 3;
                    encrypted.Append((char)letter);
                }
            }
            Console.WriteLine(encrypted);
        }
    }
}
