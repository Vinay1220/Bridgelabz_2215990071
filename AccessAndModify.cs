using System;
using System.Reflection;

public class Configuration
{
    private static string API_KEY = "InitialAPIKey";
}

class Program
{
    static void Main()
    {
        Type configType = typeof(Configuration);
        FieldInfo apiKeyField = configType.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if (apiKeyField != null)
        {
            Console.WriteLine("Before modification: " + apiKeyField.GetValue(null));
            apiKeyField.SetValue(null, "NewAPIKey123");
            Console.WriteLine("After modification: " + apiKeyField.GetValue(null));
        }
        else
        {
            Console.WriteLine("API_KEY field not found.");
        }
    }
}