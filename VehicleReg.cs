using System;

class VehicleReg
{
    private string ownerName;
    private string vehicleType;
    private static double registrationFee = 100.0; // Class variable

    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance method to display vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner: " + ownerName + ", Vehicle Type: " + vehicleType + ", Registration Fee: " + registrationFee);
    }

    // Class method to update registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
        Console.WriteLine("Registration Fee updated to: " + registrationFee);
    }
}

// Test Program
class Program
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("Alice", "Car");
        v1.DisplayVehicleDetails();

        Vehicle v2 = new Vehicle("Bob", "Bike");
        v2.DisplayVehicleDetails();

        Vehicle.UpdateRegistrationFee(120.0); // Update class variable

        // Display again after fee update
        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();
    }
}
