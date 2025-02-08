using System;

// Base class (Superclass)
public class Vehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }

    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    // Virtual method to be overridden in subclasses
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Max Speed: " + MaxSpeed + " km/h");
        Console.WriteLine("Fuel Type: " + FuelType);
    }
}

// Subclass Car
public class Car : Vehicle
{
    public int SeatCapacity { get; set; }

    public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seat Capacity: " + SeatCapacity);
    }
}

// Subclass Truck
public class Truck : Vehicle
{
    public int PayloadCapacity { get; set; } // Capacity in kilograms

    public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: " + PayloadCapacity + " kg");
    }
}

// Subclass Motorcycle
public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: " + (HasSidecar ? "Yes" : "No"));
    }
}

// Main class to test polymorphism
public class Program
{
    public static void Main()
    {
        // Array of base class type to store different subclass objects
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(200, "Petrol", 5),
            new Truck(120, "Diesel", 15000),
            new Motorcycle(180, "Petrol", false)
        };

        // Demonstrating dynamic method dispatch
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}
