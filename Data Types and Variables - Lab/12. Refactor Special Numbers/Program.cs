using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int operations = int.Parse(Console.ReadLine());
            int lastDigit = 0;
            int number = 0;
            bool isRightSum = false;
            for (int i = 1; i <= operations; i++)
            {
                int sum = 0;
                number = i;
                while (number > 0)
                {
                    lastDigit = number % 10;
                    sum += lastDigit;
                    number /= 10;
                }
                isRightSum = (sum == 5) || (sum == 7) || (sum == 11);
                {
                    Console.WriteLine($"{i} -> {isRightSum}");
                }
            }
        }
    }
}
