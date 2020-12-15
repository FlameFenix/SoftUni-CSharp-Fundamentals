using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordChecker(password);
        }

        public static void PasswordChecker(string password)
        {
            string output = string.Empty;
            int countLettersAndDigits = 0;
            int countDigits = 0;
            bool isBetweelSixAndTenChars = false;
            bool isOnlyLettersAndDigits = false;
            bool isPasswordHaveTwoDigits = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                isBetweelSixAndTenChars = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isOnlyLettersAndDigits)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if ((password[i] >= 48 && password[i] <= 57) ||
                       (password[i] >= 65 && password[i] <= 90) ||
                       (password[i] >= 97 && password[i] <= 122))
                    {
                        countLettersAndDigits++;
                        if (countLettersAndDigits == password.Length)
                        {
                            isOnlyLettersAndDigits = true;
                        }
                    }
                }
                if (!isOnlyLettersAndDigits)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
            }
            if (!isPasswordHaveTwoDigits)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] >= 48 && password[i] <= 57)
                    {
                        countDigits++;
                    }
                }
                if (countDigits >= 2)
                {
                    isPasswordHaveTwoDigits = true;
                }
                else
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            if (isBetweelSixAndTenChars && isOnlyLettersAndDigits && isPasswordHaveTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
           ;
        }
    }
}
