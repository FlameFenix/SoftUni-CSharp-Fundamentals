using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberToString = number.ToString();
            int lastDigit = 0;
            int everyDigit = number;
            int sum = 0;
            int operation = 1;
            for (int i = 0; i < numberToString.Length; i++)
            {
                operation = 1;
                lastDigit = everyDigit % 10;

                for (int x1 = 1; x1 <= lastDigit; x1++)
                {
                    operation *= x1;
                }
                sum += operation;
                everyDigit /= 10;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
