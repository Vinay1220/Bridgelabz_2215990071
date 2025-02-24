using System; 
 
class Animal 
{ 
    public virtual void MakeSound() 
    { 
        Console.WriteLine("Animal sound"); 
    } 
} 
 
class Dog : Animal 
{ 
    public override void MakeSound() 
    { 
        Console.WriteLine("Bark"); 
    } 
} 
 
class Program 
{ 
    static void Main() 
    { 
        Dog dog = new Dog(); 
        dog.MakeSound(); 
    } 
} 
