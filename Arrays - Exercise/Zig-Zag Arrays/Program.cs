using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            int[] evenSum = new int[numberOfOperations];
            int[] oddSum = new int[numberOfOperations];
            for (int i = 0; i < numberOfOperations; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int numberOne = numbers[0];
                int numberTwo = numbers[1];
                if (i % 2 == 0)
                {
                    evenSum[i] = numberOne;
                    oddSum[i] = numberTwo;
                }
                else
                {
                    evenSum[i] = numberTwo;
                    oddSum[i] = numberOne;
                }
            }
            Console.WriteLine(string.Join(" ", evenSum));
            Console.WriteLine(string.Join(" ", oddSum));
        }
    }
}
