using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
public class MaxLengthAttribute : Attribute
{
    public int Value { get; }

    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        FieldInfo fieldInfo = typeof(User).GetField("Username");
        MaxLengthAttribute maxLength = (MaxLengthAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(MaxLengthAttribute));

        if (maxLength != null && username.Length > maxLength.Value)
        {
            throw new ArgumentException("Username exceeds maximum length of " + maxLength.Value + " characters.");
        }

        Username = username;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            User user = new User("ShortName");
            Console.WriteLine("Username: " + user.Username);

            // This will throw an exception
            User invalidUser = new User("VeryLongUsername");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}