using System;
using System.Collections.Generic;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            double carsHorsepowerSum = 0;
            double trucksHorsepowerSum = 0;

            while (true)
            {
                string[] line = Console.ReadLine().Split();

                if (line[0] == "End")
                {
                    break;
                }

                if (line[0] == "car")
                {
                    Car myCars = new Car(line[0], line[1], line[2], int.Parse(line[3]));
                    cars.Add(myCars);
                    carsHorsepowerSum += int.Parse(line[3]);
                }
                else
                {
                    Truck myTrucks = new Truck(line[0], line[1], line[2], int.Parse(line[3]));
                    trucks.Add(myTrucks);
                    trucksHorsepowerSum += int.Parse(line[3]);
                }
            }

            string command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {
                string[] tokens = command.Split();
                string vehicleModel = tokens[0];

                Car existingCar = cars.Find(x => x.Model == vehicleModel);
                Truck existingTruck = trucks.Find(x => x.Model == vehicleModel);

                if (existingCar != null)
                {
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {existingCar.Model}");
                    Console.WriteLine($"Color: {existingCar.Color}");
                    Console.WriteLine($"Horsepower: {existingCar.Horsepower}");
                }

                if (existingTruck != null)
                {
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {existingTruck.Model}");
                    Console.WriteLine($"Color: {existingTruck.Color}");
                    Console.WriteLine($"Horsepower: {existingTruck.Horsepower}");
                }

                command = Console.ReadLine();
            }

            if (cars.Count > 0 && trucks.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsHorsepowerSum / cars.Count:F2}.");
                Console.WriteLine($"Trucks have average horsepower of: {trucksHorsepowerSum / trucks.Count:F2}.");
            }
            else if (cars.Count > 0 && trucks.Count <= 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsHorsepowerSum / cars.Count:F2}.");
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
            else if (cars.Count <= 0 && trucks.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
                Console.WriteLine($"Trucks have average horsepower of: {trucksHorsepowerSum / trucks.Count:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }

    }
}
class Car
{
    public Car(string type, string model, string color, int horsepower)
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
        return $"{this.Type} {this.Model} {this.Color} {this.Horsepower}";
    }
}

class Truck
{
    public Truck(string type, string model, string color, int horsepower)
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
        return $"{this.Type} {this.Model} {this.Color} {this.Horsepower}";
    }
}

