using System;

namespace Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberOne = decimal.Parse(Console.ReadLine());
            decimal numberTwo = decimal.Parse(Console.ReadLine());

            decimal diffrence = 0.000001M;
            string output = string.Empty;
            if (numberOne > numberTwo)
            {
                numberOne -= numberTwo;
                if (numberOne >= diffrence)
                {
                    output = "False";
                }
                else
                {
                    output = "True";
                }
            }
            else if (numberOne < numberTwo)
            {
                numberTwo -= numberOne;
                if (numberTwo >= diffrence)
                {
                    output = "False";
                }
                else
                {
                    output = "True";
                }
            }
            else
            {
                output = "True";
            }
            Console.WriteLine(output);
        }
    }
}
