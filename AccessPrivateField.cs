using System;
using System.Reflection;

class Person
{
    private int age;

    public Person(int age)
    {
        this.age = age;
    }

    public void DisplayAge()
    {
        Console.WriteLine("Age: " + age);
    }
}

class ReflectionExample
{
    static void Main()
    {
        Person person = new Person(25);

        Type type = typeof(Person);

        FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        if (field != null)
        {
            Console.WriteLine("Original Age: " + field.GetValue(person));

            field.SetValue(person, 30);

            Console.WriteLine("Modified Age: " + field.GetValue(person));

            person.DisplayAge();
        }
        else
        {
            Console.WriteLine("Field not found.");
        }
    }
}