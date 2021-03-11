using System;
using System.Collections.Generic;
using System.Linq;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(", ").ToList();
            for (int i = 0; i < text.Count; i++)
            {
                string user = text[i];
                if (user.Length>=3 && user.Length<=16)
                {
                    for (int j = 0; j < user.Length; j++)
                    {
                        if (!char.IsLetterOrDigit(user[j]) && user[j] != '-' && user[j] != '_')
                        {
                            text.Remove(user);
                            i--;
                            break;
                        }

                    }
                }
                else
                {
                    text.Remove(user);
                    i--;
                }
            }
            foreach (var user in text)
            {
                Console.WriteLine(user);
            }

        }
    }
}
