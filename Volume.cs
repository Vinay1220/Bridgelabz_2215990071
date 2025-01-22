using System;

class Volume
{
    static void Main()
    {
        // Radius of Earth in kilometers
        double radiusKm = 6378; 
		// Conversion factor from kilometers to miles
        double kmToMiles = 0.621371; 

        // Compute the volume of Earth in cubic kilometers
        double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

        // Compute the volume of Earth in cubic miles
        double radiusMiles = radiusKm * kmToMiles;
        double volumeMiles = (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);

        // result
        Console.WriteLine("The volume of Earth in cubic kilometers is "+volumeKm+" and in cubic miles is "+volumeMiles);
    }
}
