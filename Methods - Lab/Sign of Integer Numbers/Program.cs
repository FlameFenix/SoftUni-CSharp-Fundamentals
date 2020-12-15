using System;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int number = int.Parse(Console.ReadLine());

                PrintSign(number);
            }
            static void PrintSign(int number)
            {
                string output = string.Empty;
                if (number > 0)
                {
                    output = $"The number {number} is positive.";
                }
                else if (number < 0)
                {
                    output = $"The number {number} is negative.";
                }
                else
                {
                    output = $"The number {number} is zero.";
                }
                Console.WriteLine(output);
            }
        }
    }
}
