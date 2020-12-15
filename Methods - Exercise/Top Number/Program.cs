using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNumber(number);
        }

        public static void TopNumber(int number)
        {
            int sumOfDigits = 0;
            for (int i = 0; i <= number; i++)
            {
                int currentNumber = i;
                sumOfDigits = 0;
                bool isSumWithOdd = false;
                bool isDivisible = false;
                while (currentNumber > 0)
                {
                    int lastDigit = currentNumber % 10;
                    sumOfDigits += lastDigit;
                    currentNumber /= 10;
                    if (lastDigit % 2 == 1)
                    {
                        isSumWithOdd = true;
                    }
                }
                if (sumOfDigits % 8 == 0)
                {
                    isDivisible = true;
                }
                if (isSumWithOdd && isDivisible)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
