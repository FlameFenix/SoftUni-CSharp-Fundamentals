using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int countCourses = 0;
            while(numberOfPeople > 0)
            {
                countCourses++;
                numberOfPeople -= capacity;
            }
            Console.WriteLine(countCourses);
        }
    }
}
