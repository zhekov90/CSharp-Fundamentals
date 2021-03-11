using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            CheckPasswordRules(password);

        }

        private static bool CheckPasswordRules(string password)
        {
            bool isValid = false;
            bool passwordLength = CheckChars(password);
            bool passwordLettersAndDigits = CheckLettersAndDigits(password);
            bool passwordTwoDigitsRule = CheckTwoDigitsRule(password);
            if (passwordLength && passwordLettersAndDigits && passwordTwoDigitsRule)
            {
                isValid = true;
                Console.WriteLine("Password is valid");
            }
            return isValid;
        }

        private static bool CheckTwoDigitsRule(string password)
        {
            bool twoDigits = true;
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                int current = password[i];
                if (current >= 48 && current <= 57)
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                twoDigits = true;

            }
            else
            {
                twoDigits = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            return twoDigits;
        }

        private static bool CheckLettersAndDigits(string password)
        {
            bool letterOrDigit = true;
            for (int i = 0; i < password.Length; i++)
            {
                int current = password[i];
                if ((current >= 65 && current <= 90) || (current >= 97 && current <= 122) || (current >= 48 && current <= 57))
                {
                    letterOrDigit = true;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    letterOrDigit = false;
                    break;
                }
            }
            return letterOrDigit;
        }

        private static bool CheckChars(string password)
        {
            bool charsCheck = true;
            string[] arr = new string[password.Length];
            if (arr.Length >= 6 && arr.Length <= 10)
            {
                charsCheck = true;
            }
            else
            {
                charsCheck = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            return charsCheck;
        }
    }
}
