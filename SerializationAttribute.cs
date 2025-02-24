using System;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Field)]
public class JsonFieldAttribute : Attribute
{
    public string Name { get; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

class User
{
    [JsonField("user_name")]
    public string Username;

    [JsonField("user_age")]
    public int Age;

    public User(string username, int age)
    {
        Username = username;
        Age = age;
    }
}

class JsonSerializer
{
    public static string Serialize(object obj)
    {
        StringBuilder json = new StringBuilder("{");

        FieldInfo[] fields = obj.GetType().GetFields();
        foreach (var field in fields)
        {
            JsonFieldAttribute jsonField = (JsonFieldAttribute)Attribute.GetCustomAttribute(field, typeof(JsonFieldAttribute));
            if (jsonField != null)
            {
                if (json.Length > 1)
                    json.Append(", ");
                json.Append($"\"{jsonField.Name}\": \"{field.GetValue(obj)}\"");
            }
        }

        json.Append("}");
        return json.ToString();
    }
}

class Program
{
    static void Main()
    {
        User user = new User("JohnDoe", 30);
        string json = JsonSerializer.Serialize(user);
        Console.WriteLine(json);
    }
}