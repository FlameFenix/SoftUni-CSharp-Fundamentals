using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                number = Math.Abs(number);
            }

            int even = GetSumOfEvenDigits(number);
            int odd = GetSumOfOddDigits(number);
            GetMultipleOfEvenAndOdds(even, odd);
        }
        static void GetMultipleOfEvenAndOdds(int even, int odd)
        {
            int sum = even * odd;
            Console.WriteLine(sum);
        }

        static int GetSumOfEvenDigits(int evenSum)
        {
            int even = 0;
            int number = evenSum;
            for (int i = 0; i < evenSum.ToString().Length; i++)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    even += lastDigit;
                }
                number /= 10;
            }
            return even;
        }

        static int GetSumOfOddDigits(int oddSum)
        {
            int odd = 0;
            int number = oddSum;
            for (int i = 0; i < oddSum.ToString().Length; i++)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 1)
                {
                    odd += lastDigit;
                }
                number /= 10;
            }
            return odd;
        }
    }
}
