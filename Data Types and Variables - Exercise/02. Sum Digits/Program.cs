using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string operations = number.ToString();
            int sumOfNumbers = 0;
            for (int i = 0; i < operations.Length; i++)
            {
               int currentNumber = (int)Char.GetNumericValue(number[i]);
                sumOfNumbers += currentNumber;
               // int lastDigit = number % 10;
               // sumOfNumbers += lastDigit;
               // number /= 10;
            }
            Console.WriteLine($"{sumOfNumbers}");
        }
    }
}
