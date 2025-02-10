using System;
using System.Collections.Generic;

// Abstract class Vehicle
abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    protected double rentalRate;

    public string VehicleNumber { get { return vehicleNumber; } }
    public string Type { get { return type; } }

    public Vehicle(string number, string vehicleType, double rate)
    {
        vehicleNumber = number;
        type = vehicleType;
        rentalRate = rate;
    }

    public abstract double CalculateRentalCost(int days);

    public virtual void DisplayDetails(int days)
    {
        Console.WriteLine("Vehicle Number: " + vehicleNumber);
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Rental Cost for " + days + " days: " + CalculateRentalCost(days));
    }
}

// Interface for insurance calculation
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Car class
class Car : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Car(string number, double rate, string policyNumber) : base(number, "Car", rate)
    {
        insurancePolicyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.05; // 5% insurance cost
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance Policy: " + insurancePolicyNumber;
    }
}

// Bike class
class Bike : Vehicle
{
    public Bike(string number, double rate) : base(number, "Bike", rate) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days * 0.9; // 10% discount for bikes
    }
}

// Truck class
class Truck : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Truck(string number, double rate, string policyNumber) : base(number, "Truck", rate)
    {
        insurancePolicyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days * 1.2; // 20% extra charge for trucks
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.1; // 10% insurance cost
    }

    public string GetInsuranceDetails()
    {
        return "Truck Insurance Policy: " + insurancePolicyNumber;
    }
}

// Main Program
class Program
{
    static void ProcessVehicles(List<Vehicle> vehicles, int days)
    {
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayDetails(days);
            
            if (vehicle is IInsurable)
            {
                IInsurable insurableVehicle = (IInsurable)vehicle;
                Console.WriteLine(insurableVehicle.GetInsuranceDetails());
                Console.WriteLine("Insurance Cost: " + insurableVehicle.CalculateInsurance());
            }

            Console.WriteLine("----------------------");
        }
    }

    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        vehicles.Add(new Car("KA01AB1234", 500, "CAR-INS-001"));
        vehicles.Add(new Bike("MH02XY5678", 200));
        vehicles.Add(new Truck("DL03TR9876", 1000, "TRUCK-INS-002"));

        int rentalDays = 5;
        ProcessVehicles(vehicles, rentalDays);
    }
}
