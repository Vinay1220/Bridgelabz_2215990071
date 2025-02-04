using System;

class Vehicle
{
    private static double RegistrationFee = 5000.0;
    private readonly string RegistrationNumber;
    private string OwnerName;
    private string VehicleType;

    public Vehicle(string RegistrationNumber, string OwnerName, string VehicleType)
    {
        this.RegistrationNumber = RegistrationNumber;
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
    }

    public void DisplayVehicleDetails()
    {
        if (this is Vehicle)
        {
            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("Owner Name: " + OwnerName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Registration Fee: " + RegistrationFee);
        }
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine("Updated Registration Fee: " + RegistrationFee);
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle1 = new Vehicle("ABC1234", "Vinay Pal", "Car");
        vehicle1.DisplayVehicleDetails();
        
        Vehicle.UpdateRegistrationFee(6000);
    }
}
