using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            List<Catalogue> newCatalogue = new List<Catalogue>();

            int horsepowersCars = 0;
            int horsepowersTrucks = 0;

            int countCars = 0;
            int countTrucks = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                string type = cmdArgs[0];
                string model = cmdArgs[1];
                string color = cmdArgs[2];
                int horsepower = int.Parse(cmdArgs[3]);

                if (type == "car")
                {
                    horsepowersCars += horsepower;
                    countCars++;
                    type = "Car";
                }
                else
                {
                    horsepowersTrucks += horsepower;
                    countTrucks++;
                    type = "Truck";
                }

                Catalogue currentVehicle = new Catalogue(type, model, color, horsepower);

                newCatalogue.Add(currentVehicle);


            }

            string cmd = Console.ReadLine();

            while (cmd != "Close the Catalogue")
            {
                Catalogue vehicleRequest = newCatalogue.FirstOrDefault(x => x.Model == cmd);

                if (newCatalogue.Contains(vehicleRequest))
                {
                    Console.WriteLine(vehicleRequest);
                }
                cmd = Console.ReadLine();
            }

            double carsAverage = 0;
            double trucksAverage = 0;

            if (countCars > 0 && countTrucks > 0)
            {
                carsAverage = horsepowersCars * 1.0 / countCars;
                trucksAverage = horsepowersTrucks * 1.0 / countTrucks;
            }
            else if (countCars > 0 && countTrucks == 0)
            {
                carsAverage = horsepowersCars * 1.0 / countCars;
                trucksAverage = 0;
            }
            else if (countCars == 0 && countTrucks > 0)
            {
                carsAverage = 0;
                trucksAverage = horsepowersTrucks * 1.0 / countTrucks;
            }
            Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:f2}.");
        }
    }

    class Catalogue
    {
        public Catalogue(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().TrimEnd();
        }
    }
