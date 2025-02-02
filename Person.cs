using System;

class Person
{
    private string name;
    private int age;

    // Parameterized constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy constructor
    public Person(Person other)
    {
        this.name = other.name;
        this.age = other.age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }
}

// Test Program
class Program
{
    static void Main()
    {
        Person person1 = new Person("Alice", 25);
        person1.Display();

        Person person2 = new Person(person1); // Copy constructor
        person2.Display();
    }
}
