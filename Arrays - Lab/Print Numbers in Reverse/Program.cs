using System;

namespace Print_Numbers_in_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            int[] arr = new int[numberOfOperations];

            for (int i = 0; i < numberOfOperations; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numberOfOperations - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
