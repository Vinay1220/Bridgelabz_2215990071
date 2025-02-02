using System;

class HotelBooking
{
    private string guestName;
    private string roomType;
    private int nights;

    // Default constructor
    public HotelBooking()
    {
        guestName = "Unknown";
        roomType = "Standard";
        nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy constructor
    public HotelBooking(HotelBooking other)
    {
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

    public void Display()
    {
        Console.WriteLine("Guest: " + guestName + ", Room: " + roomType + ", Nights: " + nights);
    }
}

// Test Program
class Program
{
    static void Main()
    {
        HotelBooking booking1 = new HotelBooking("John Doe", "Deluxe", 3);
        booking1.Display();

        HotelBooking booking2 = new HotelBooking(booking1); // Copy constructor
        booking2.Display();
    }
}
