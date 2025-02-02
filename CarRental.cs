using System;

class CarRental
{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double rentalRate;

    // Default constructor
    public CarRental()
    {
        customerName = "Unknown";
        carModel = "Standard";
        rentalDays = 1;
        rentalRate = 50.0;
    }

    // Parameterized constructor
    public CarRental(string customerName, string carModel, int rentalDays, double rentalRate)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        this.rentalRate = rentalRate;
    }

    // Method to calculate total cost
    private double CalculateTotalCost()
    {
        return rentalDays * rentalRate;
    }

    public void Display()
    {
        Console.WriteLine("Customer: " + customerName + ", Car Model: " + carModel + ", Days: " + rentalDays + ", Total Cost: " + CalculateTotalCost());
    }
}

// Test Program
class Program
{
    static void Main()
    {
        CarRental rental1 = new CarRental("Alice Brown", "SUV", 5, 75.0);
        rental1.Display();
    }
}
