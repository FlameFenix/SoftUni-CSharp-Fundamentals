using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharsInRange(firstChar, secondChar);
        }

        public static void CharsInRange(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                char currentFirstChar = firstChar;
                firstChar = secondChar;
                secondChar = currentFirstChar;
            }
            for (int i = firstChar + 1; i < secondChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
