using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                        .Split(" ")
                                        .Select(int.Parse)
                                        .ToArray();
            bool isFound = false;
            for (int index = 0; index < arr.Length; index++)
            {
                int rightSum = 0;

                for (int i = index + 1; i < arr.Length; i++)
                {
                    rightSum += arr[i];
                }

                int leftSum = 0;

                for (int i = index - 1; i >= 0; i--)
                {
                    leftSum += arr[i];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine($"{index}");
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
