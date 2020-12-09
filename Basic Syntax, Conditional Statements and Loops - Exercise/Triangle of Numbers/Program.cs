using System;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int x1 = 1; x1 <= n; x1++)
            {
                for (int x2 = 1; x2 <= x1; x2++)
                {
                    Console.Write($"{x1} ");
                }
                Console.WriteLine();
            }
        }
    }
}
