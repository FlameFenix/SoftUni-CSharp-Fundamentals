using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                TriangleDraw(1, i);
            }
            for (int i = number - 1; i >= 0; i--)
            {
                TriangleDraw(1, i);
            }

        }

        static void TriangleDraw(int start, int end)
        {
            for (int j = start; j <= end; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}
