using System; 
 
// Interface representing a worker 
public interface IWorker 
{ 
    void PerformDuties(); 
} 
 
// Base class Person 
public class Person 
{ 
    public string Name { get; set; } 
    public int Id { get; set; } 
 
    public Person(string name, int id) 
    { 
        Name = name; 
        Id = id; 
    } 
} 
 
// Subclass Chef implementing IWorker interface 
public class Chef : Person, IWorker 
{ 
    public Chef(string name, int id) : base(name, id) { } 
     
    public void PerformDuties() 
    { 
        Console.WriteLine("Chef {0} is preparing meals.", Name); 
    } 
} 
 
// Subclass Waiter implementing IWorker interface 
public class Waiter : Person, IWorker 
{ 
    public Waiter(string name, int id) : base(name, id) { } 
     
    public void PerformDuties() 
    { 
        Console.WriteLine("Waiter {0} is serving customers.", Name); 
    } 
} 
 
// Main Program 
public class Program 
{ 
    public static void Main() 
    { 
        IWorker chef = new Chef("John", 101); 
        IWorker waiter = new Waiter("Emma", 102); 
         
        chef.PerformDuties(); 
        waiter.PerformDuties(); 
    } 
}