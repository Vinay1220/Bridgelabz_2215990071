using System;

class Trip
{
    static void Main()
    {
        // Input for journey details
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the fromCity:");
        string fromCity = Console.ReadLine();

        Console.WriteLine("Enter the viaCity:");
        string viaCity = Console.ReadLine();

        Console.WriteLine("Enter the toCity:");
        string toCity = Console.ReadLine();

        Console.WriteLine("Enter the distance from fromCity to viaCity (in miles):");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the distance from viaCity to toCity (in miles):");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time taken for the journey (in hours):");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Calculate and output the results
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine("The results of the trip are: "+name+"," +totalDistance+", Average Speed: "+averageSpeed+"miles/hour");
    }
}
