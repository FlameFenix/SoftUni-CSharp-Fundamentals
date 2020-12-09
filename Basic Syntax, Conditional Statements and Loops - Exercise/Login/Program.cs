using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            int countIncorrectPasswords = 0;

            while (userName != password)
            {
                string currentPassword = Console.ReadLine();
                for (int i = currentPassword.Length - 1; i >= 0; i--)
                {
                    password += currentPassword[i];
                }

                if (password != userName)
                {
                    countIncorrectPasswords++;
                    if (countIncorrectPasswords == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    password = string.Empty;
                }
                else
                {
                    Console.WriteLine($"User {userName} logged in.");
                }
            }
        }
    }
}
