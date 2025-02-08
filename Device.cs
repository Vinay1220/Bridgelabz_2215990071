using System;

// Superclass: Device
public class Device
{
    public int DeviceId { get; set; }
    public string Status { get; set; }

    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}

// Subclass: Thermostat (inherits from Device)
public class Thermostat : Device
{
    public double TemperatureSetting { get; set; }

    public Thermostat(int deviceId, string status, double temperatureSetting)
        : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: " + TemperatureSetting + "°C");
    }
}

// Main Class
public class Program
{
    public static void Main()
    {
        Thermostat thermostat1 = new Thermostat(101, "Active", 22.5);
        thermostat1.DisplayStatus();
    }
}
