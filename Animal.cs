using System;

// Base class (Superclass)
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method to be overridden by subclasses
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Subclass Dog
public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine(Name + " barks.");
    }
}

// Subclass Cat
public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine(Name + " meows.");
    }
}

// Subclass Bird
public class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine(Name + " chirps.");
    }
}

// Main class to test polymorphism
public class Program
{
    public static void Main()
    {
        Animal myDog = new Dog("Buddy", 3);
        Animal myCat = new Cat("Whiskers", 2);
        Animal myBird = new Bird("Tweety", 1);

        myDog.MakeSound();  // Output: Buddy barks.
        myCat.MakeSound();  // Output: Whiskers meows.
        myBird.MakeSound(); // Output: Tweety chirps.
    }
}
