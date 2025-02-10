using System;
using System.Collections.Generic;

// Abstract class Vehicle
abstract class Vehicle
{
    private int vehicleId;
    private string driverName;
    protected double ratePerKm;

    public int VehicleId { get { return vehicleId; } }
    public string DriverName { get { return driverName; } }

    public Vehicle(int vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + vehicleId);
        Console.WriteLine("Driver Name: " + driverName);
        Console.WriteLine("Rate per Km: $" + ratePerKm);
    }
}

// Interface for GPS functionality
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Car Class
class Car : Vehicle, IGPS
{
    private string currentLocation;

    public Car(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm)
    {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public string GetCurrentLocation()
    {
        return "Car Current Location: " + currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Bike Class
class Bike : Vehicle, IGPS
{
    private string currentLocation;

    public Bike(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm)
    {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public string GetCurrentLocation()
    {
        return "Bike Current Location: " + currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Auto Class
class Auto : Vehicle, IGPS
{
    private string currentLocation;

    public Auto(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm)
    {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public string GetCurrentLocation()
    {
        return "Auto Current Location: " + currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Main Program
class Program
{
    static void ProcessRides(List<Vehicle> vehicles, double distance)
    {
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine("Fare for " + distance + " km: $" + vehicle.CalculateFare(distance));

            // Handle GPS functionality dynamically
            IGPS gps = vehicle as IGPS;
            if (gps != null)
            {
                gps.UpdateLocation("Downtown");
                Console.WriteLine(gps.GetCurrentLocation());
            }

            Console.WriteLine("----------------------");
        }
    }

    static void Main()
    {
        List<Vehicle> rideVehicles = new List<Vehicle>();

        Car car1 = new Car(101, "Vinay", 5);
        Bike bike1 = new Bike(102, "Boby", 2);
        Auto auto1 = new Auto(103, "Satendra", 3);

        rideVehicles.Add(car1);
        rideVehicles.Add(bike1);
        rideVehicles.Add(auto1);

        ProcessRides(rideVehicles, 10);
    }
}
