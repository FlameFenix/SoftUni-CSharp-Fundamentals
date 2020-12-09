using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                if (numberTwo >= 10)
                {
                    Console.WriteLine($"{numberOne} X {numberTwo} = {numberOne * numberTwo}");
                    break;
                }
                else
                {
                    Console.WriteLine($"{numberOne} X {numberTwo} = {numberOne * numberTwo}");
                }
                numberTwo++;
            }
        }
    }
}
