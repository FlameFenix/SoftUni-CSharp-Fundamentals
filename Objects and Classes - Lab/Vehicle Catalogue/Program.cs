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

            Catalogue types = new Catalogue();

            List<Car> CarsCat = new List<Car>();

            List<Truck> TruckCat = new List<Truck>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(@"/", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                string type = cmdArgs[0];
                string brand = cmdArgs[1];
                string model = cmdArgs[2];
                int hpOrWeight = int.Parse(cmdArgs[3]);

                if (type == "Car")
                {
                    Car currentCar = new Car();
                    currentCar.Brand = brand;
                    currentCar.Model = model;
                    currentCar.HorsePower = hpOrWeight;

                    CarsCat.Add(currentCar);
                }
                else
                {
                    Truck currentTruck = new Truck();
                    currentTruck.Brand = brand;
                    currentTruck.Model = model;
                    currentTruck.Weight = hpOrWeight;

                    TruckCat.Add(currentTruck);
                }
            }

            types.Cars = CarsCat;
            types.Trucks = TruckCat;
            if (types.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var item in types.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }


            if (types.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var item in types.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }

        }
    }

    class Catalogue
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    class Car
    {

        // Brand, Model and Horse Power.
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        // Brand, Model and Weight.
        public string Brand { get; set; }
        public string Model { get; set; }

        public int Weight { get; set; }
    }
}
