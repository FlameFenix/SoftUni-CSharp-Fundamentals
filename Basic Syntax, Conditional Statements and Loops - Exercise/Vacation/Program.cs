using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pricePerOnePerson = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    pricePerOnePerson = 8.45 * numberOfPeople;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pricePerOnePerson = 9.80 * numberOfPeople;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pricePerOnePerson = 10.46 * numberOfPeople;
                }
                if (numberOfPeople >= 30)
                {
                    pricePerOnePerson *= 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (numberOfPeople >= 100)
                {
                    numberOfPeople -= 10;
                }
                if (dayOfWeek == "Friday")
                {
                    pricePerOnePerson = 10.90 * numberOfPeople;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pricePerOnePerson = 15.60 * numberOfPeople;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pricePerOnePerson = 16 * numberOfPeople;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    pricePerOnePerson = 15 * numberOfPeople;
                }
                else if (dayOfWeek == "Saturday")
                {
                    pricePerOnePerson = 20 * numberOfPeople;
                }
                else if (dayOfWeek == "Sunday")
                {
                    pricePerOnePerson = 22.50 * numberOfPeople;
                }
                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    pricePerOnePerson *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {pricePerOnePerson:f2}");
        }
    }
}
