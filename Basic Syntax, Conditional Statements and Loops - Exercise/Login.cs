using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPassword = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPassword += username[i];
            }



            for (int j = 1; j <= 4; j++)
            {
                string password = Console.ReadLine();

                if (password == correctPassword)
                {

                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (j <= 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");
                }

            }

        }
    }
}
