using System;
using System.Reflection;
using System.Text;

public class JsonConverter
{
    public static string ToJson(object obj)
    {
        StringBuilder json = new StringBuilder();
        json.Append("{");

        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        for (int i = 0; i < fields.Length; i++)
        {
            FieldInfo field = fields[i];
            object value = field.GetValue(obj);

            json.Append($"\"{field.Name}\": \"{value}\"");

            if (i < fields.Length - 1)
            {
                json.Append(", ");
            }
        }

        json.Append("}");
        return json.ToString();
    }
}

public class Person
{
    private string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("John Doe", 30);
        string json = JsonConverter.ToJson(person);

        Console.WriteLine(json);
    }
}