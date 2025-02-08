using System; 
 
// Interface representing refuelable vehicles 
public interface IRefuelable 
{ 
    void Refuel(); 
} 
 
// Base class Vehicle 
public class Vehicle 
{ 
    public string Model { get; set; } 
    public int MaxSpeed { get; set; } 
 
    public Vehicle(string model, int maxSpeed) 
    { 
        Model = model; 
        MaxSpeed = maxSpeed; 
    } 
 
    public void DisplayInfo() 
    { 
        Console.WriteLine("Model: {0}, Max Speed: {1} km/h", Model, 
MaxSpeed); 
    } 
} 
 
// Subclass ElectricVehicle 
public class ElectricVehicle : Vehicle 
{ 
    public ElectricVehicle(string model, int maxSpeed) : base(model, 
maxSpeed) { } 
     
    public void Charge() 
    { 
        Console.WriteLine("Electric vehicle {0} is charging.", Model); 
    } 
} 
 
// Subclass PetrolVehicle implementing IRefuelable interface 
public class PetrolVehicle : Vehicle, IRefuelable 
{ 
    public PetrolVehicle(string model, int maxSpeed) : base(model, 
maxSpeed) { } 
     
    public void Refuel() 
    { 
        Console.WriteLine("Petrol vehicle {0} is refueling.", Model); 
    } 
} 
 
// Main Program 
public class Program 
{ 
    public static void Main() 
    { 
        ElectricVehicle ev = new ElectricVehicle("Tesla Model 3", 200); 
        PetrolVehicle pv = new PetrolVehicle("Ford Mustang", 250); 
         
        ev.DisplayInfo(); 
        ev.Charge(); 
         
        pv.DisplayInfo(); 
        pv.Refuel(); 
    } 
} 