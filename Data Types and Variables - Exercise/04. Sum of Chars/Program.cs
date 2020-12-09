using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            int sumOfLetters = 0;
            for (int i = 0; i < numberOfOperations; i++)
            {
                char n = char.Parse(Console.ReadLine());
                sumOfLetters += (int)n;
            }
            Console.WriteLine($"The sum equals: {sumOfLetters}");
        }
    }
}
