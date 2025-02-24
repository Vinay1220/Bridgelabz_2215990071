using System;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("John Doe")]
public class SampleClass
{
    public void Display()
    {
        Console.WriteLine("This is a sample class.");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(SampleClass);
        AuthorAttribute authorAttr = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        if (authorAttr != null)
        {
            Console.WriteLine("Author: " + authorAttr.Name);
        }
        else
        {
            Console.WriteLine("No author information found.");
        }
    }
}