using System;

namespace Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numberOfOperations; i++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < i; divider++)
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                string booleanOutput = isPrime.ToString();
                Console.WriteLine($"{i} -> {booleanOutput.ToLower()}");
            }
        }
    }
}
