using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();

                string model = cmdArgs[0];
                double fuelAmount = double.Parse(cmdArgs[1]);
                double consumption = double.Parse(cmdArgs[2]);

                Car currentCar = new Car(model, fuelAmount, consumption);

                cars.Add(currentCar);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split();

                string model = cmdArgs[1];
                double kilometers = double.Parse(cmdArgs[2]);

                Car currentCar = cars.Find(x => x.Model == model);

                if(currentCar != null)
                {
                    currentCar.Drive(kilometers);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

    class Car
    {
        public Car(string model, double fuelAmount, double consumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.Consumption = consumption;
        }

        public string Model { get; set; }
        
        public double FuelAmount { get; set; }

        public double Consumption { get; set; }

        public double DistanceTraveled { get; set; }

        public void Drive(double kilometers)
        {
            if(FuelAmount > kilometers * Consumption)
            {
                this.FuelAmount -= kilometers * this.Consumption;
                this.DistanceTraveled += kilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.DistanceTraveled}";
        }
    }
}
