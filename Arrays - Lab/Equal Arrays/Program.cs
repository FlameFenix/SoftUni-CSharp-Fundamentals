using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool isIdentical = true;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr2.Length; j++)
                {
                    if (arr[i] == arr2[j])
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {j} index");
                        isIdentical = false;
                        break;

                    }

                }
                if (!isIdentical)
                {
                    break;
                }
            }
            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {arr.Sum()}");
            }
        }
    }
}
