using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            char symbol = ' ';
            for (int i = numberOne; i <= numberTwo; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
