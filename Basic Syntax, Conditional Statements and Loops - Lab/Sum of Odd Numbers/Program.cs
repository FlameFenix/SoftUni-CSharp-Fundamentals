using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            int sumOddNumbers = 0;
            for (int i = 1; i < numberOfOperations * 2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sumOddNumbers += i;
                }
            }
            Console.WriteLine($"Sum: {sumOddNumbers}");
        }
    }
}
