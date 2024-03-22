using System;
using System.Collections.Generic;
using System.Linq;

public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
}

public class Truck : Vehicle
{
    public int Weight { get; set; }
}

public class Car : Vehicle
{
    public int HorsePower { get; set; }
}

public class Catalog
{
    public List<Truck> Trucks { get; set; } = new List<Truck>();
    public List<Car> Cars { get; set; } = new List<Car>();
}

class Program
{
    static void Main(string[] args)
    {
        Catalog catalog = new Catalog();
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] parts = input.Split('/');
            string type = parts[0];
            string brand = parts[1];
            string model = parts[2];
            int spec = int.Parse(parts[3]);

            if (type == "Truck")
            {
                catalog.Trucks.Add(new Truck { Brand = brand, Model = model, Weight = spec });
            }
            else if (type == "Car")
            {
                catalog.Cars.Add(new Car { Brand = brand, Model = model, HorsePower = spec });
            }
        }

        Console.WriteLine("Cars:");
        foreach (var car in catalog.Cars.OrderBy(c => c.Brand))
        {
            Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
        }

        Console.WriteLine("Trucks:");
        foreach (var truck in catalog.Trucks.OrderBy(t => t.Brand))
        {
            Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
        }
    }
}
