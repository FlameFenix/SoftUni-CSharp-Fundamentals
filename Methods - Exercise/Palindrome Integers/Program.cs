using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            PalindromeIntegers(command);
        }

        public static void PalindromeIntegers(string command)
        {

            while (command != "END")
            {
                string numberOne = string.Empty;
                string numberTwo = string.Empty;
                for (int i = 0; i < command.Length; i++)
                {
                    numberOne += command[i];
                }

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    numberTwo += command[i];
                }

                if (numberOne == numberTwo)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
            }
        }
    }
}
