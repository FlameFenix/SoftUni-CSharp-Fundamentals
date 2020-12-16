using System;
using System.Linq;

namespace From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            string numberOne = string.Empty;
            string numberTwo = string.Empty;

            for (int i = 0; i < numberOfOperations; i++)
            {
                long[] numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(long.Parse)
                                       .ToArray();

                if (numbers[0] > numbers[1])
                {
                    if (numbers[0] > 0)
                    {
                        string numberOneSum = numbers[0].ToString();
                        Compare(numberOneSum);
                    }
                    else
                    {
                        numbers[0] = Math.Abs(numbers[0]);
                        string numberOneSum = numbers[0].ToString();

                        Compare(numberOneSum);
                    }
                }
                else
                {
                    if (numbers[1] > 0)
                    {
                        string numberTwoSum = numbers[1].ToString();
                        Compare(numberTwoSum);
                    }
                    else
                    {
                        numbers[1] = Math.Abs(numbers[1]);

                        string numberTwoSum = numbers[1].ToString();
                        Compare(numberTwoSum);
                    }
                }
            }
        }
        public static void Compare(string number)
        {
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i] - 48;
            }

            Console.WriteLine(sum);
        }
    }
}
