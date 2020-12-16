using System;

namespace Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool isInteger = int.TryParse(input, out int integer);
                bool isFloatingPoint = double.TryParse(input, out double floatingPoint);
                bool isChar = char.TryParse(input, out char character);
                bool isBoolean = bool.TryParse(input, out bool boolean);
                if (isInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isFloatingPoint)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isBoolean)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
