using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            FactorialDivision(numberOne, numberTwo);
        }

        public static double FactorialDivision(int numberOne, int numberTwo)
        {
            double result = 0;
            double firstFactorial = 1;
            double secondFactorial = 1;

            for (int i = 1; i <= numberOne; i++)
            {
                firstFactorial *= i;
            }
            for (int i = 1; i <= numberTwo; i++)
            {
                secondFactorial *= i;
            }
            result = firstFactorial / secondFactorial;
            Console.WriteLine($"{result:f2}");
            return result;
        }
    }
}
