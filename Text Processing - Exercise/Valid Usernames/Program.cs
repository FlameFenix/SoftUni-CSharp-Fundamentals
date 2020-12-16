using System;
using System.Linq;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

            string validUsername = string.Empty;

            for (int i = 0; i < usernames.Length; i++)
            {
                string currentUsername = usernames[i];
                if (currentUsername.Length > 3 && currentUsername.Length < 16)
                {
                    int counter = 0;

                    for (int j = 0; j < currentUsername.Length; j++)
                    {
                        char currentChar = currentUsername[j];
                        if (char.IsDigit(currentChar))
                        {
                            counter++;
                        }
                        else if (char.IsLetter(currentChar))
                        {
                            counter++;
                        }
                        else if (currentChar == '-')
                        {
                            counter++;
                        }
                        else if (currentChar == '_')
                        {
                            counter++;
                        }

                        if (counter == currentUsername.Length)
                        {
                            validUsername = usernames[i];
                            Console.WriteLine(validUsername);
                        }
                    }
                }
            }
        }
    }
}
