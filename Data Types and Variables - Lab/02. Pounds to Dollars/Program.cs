﻿using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal usd = pounds * 1.31M;
            Console.WriteLine($"{usd:f3}");
        }
    }
}
