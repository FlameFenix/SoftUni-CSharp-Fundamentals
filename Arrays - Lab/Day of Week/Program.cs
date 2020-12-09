using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[]
                        {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
                        };
            int numberOfDay = int.Parse(Console.ReadLine());
            if (numberOfDay < 1 || numberOfDay > days.Length)
            {
                Console.Write("Invalid day!");
            }
            else
            {
                Console.Write(days[numberOfDay - 1]);
            }
        }
    }
}
