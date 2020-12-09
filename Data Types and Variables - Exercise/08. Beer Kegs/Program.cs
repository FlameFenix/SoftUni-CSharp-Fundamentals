using System;

namespace _8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string biggestKegName = string.Empty;
            for (int i = 0; i < numberOfOperations; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double kegSize = Math.PI * Math.Pow(radius, 2) * height;

                if(kegSize > biggestKeg)
                {
                    biggestKeg = kegSize;
                    biggestKegName = modelOfKeg;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
