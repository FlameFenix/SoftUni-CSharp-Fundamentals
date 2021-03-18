using System;
using System.Collections.Generic;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfVehicles = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfVehicles; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];

                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                CarGo cargo = new CarGo(cargoWeight, cargoType);

                Car currentCar = new Car(model, engine, cargo);
                cars.Add(currentCar);
            }

            string type = Console.ReadLine();

            if(type == "fragile")
            {
                foreach (var item in cars)
                {
                    if(item.Cargo.Type == "fragile" && item.Cargo.Weight < 1000)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else if (type == "flamable")
            {
                foreach (var item in cars)
                {
                    if(item.Cargo.Type == "flamable" && item.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }

    class Car
    {
        public Car(string model, Engine engine, CarGo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public CarGo Cargo { get; set; }

        public override string ToString()
        {
            return $"{this.Model}";
        }
    }

    class CarGo
    {
        public CarGo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public int Weight { get; set; }

        public string Type { get; set; }
    }

    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.EnigneSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public int EnigneSpeed { get; set; }

        public int EnginePower { get; set; }
    }
}
