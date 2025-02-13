using System;

class PetrolPumpTour
{
    public static int FindStartingPump(int[] petrol, int[] distance)
    {
        int totalPetrol = 0, totalDistance = 0;
        int currentPetrol = 0;
        int startIndex = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            totalPetrol += petrol[i];
            totalDistance += distance[i];

            currentPetrol += petrol[i] - distance[i];

            // If at any point fuel goes negative, reset start index to next pump
            if (currentPetrol < 0)
            {
                startIndex = i + 1;
                currentPetrol = 0;
            }
        }

        return (totalPetrol >= totalDistance) ? startIndex : -1; // -1 means no possible tour
    }
}

// Main Program
class Program
{
    static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int startPump = PetrolPumpTour.FindStartingPump(petrol, distance);

        if (startPump != -1)
            Console.WriteLine(String.Format("Start the tour from petrol pump index: {0}", startPump));
        else
            Console.WriteLine("No valid starting point found.");
    }
}
