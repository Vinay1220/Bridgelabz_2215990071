using System;
using System.Collections.Generic;
using System.Reflection;

public class CustomObjectMapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties)
    {
        T obj = (T)Activator.CreateInstance(clazz);

        foreach (var property in properties)
        {
            FieldInfo fieldInfo = clazz.GetField(property.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (fieldInfo != null)
            {
                fieldInfo.SetValue(obj, property.Value);
            }
        }

        return obj;
    }
}

public class Person
{
    private string name;
    public int age;

    public string GetName()
    {
        return name;
    }
}

class Program
{
    static void Main()
    {
        var properties = new Dictionary<string, object>
        {
            { "name", "John Doe" },
            { "age", 30 }
        };

        Person person = CustomObjectMapper.ToObject<Person>(typeof(Person), properties);

        Console.WriteLine("Name: " + person.GetName());
        Console.WriteLine("Age: " + person.age);
    }
}