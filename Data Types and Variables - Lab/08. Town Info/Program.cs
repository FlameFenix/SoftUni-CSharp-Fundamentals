using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());
            short square = short.Parse(Console.ReadLine());
            Console.WriteLine($"Town {nameOfTown} has population of {numberOfPeople} and area {square} square km.");
        }
    }
}
