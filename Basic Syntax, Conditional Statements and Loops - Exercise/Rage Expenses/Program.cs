using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetSum = headsetPrice * Math.Floor(lostGamesCount / 2.0);
            double mouseSum = mousePrice * Math.Floor(lostGamesCount / 3.0);
            double keyboardSum = keyboardPrice * Math.Floor(lostGamesCount / 6.0);
            double displaySum = displayPrice * Math.Floor(lostGamesCount / 12.0);

            double finalSum = headsetSum + mouseSum + keyboardSum + displaySum;
            Console.WriteLine($"Rage expenses: {finalSum:f2} lv.");
        }
    }
}
