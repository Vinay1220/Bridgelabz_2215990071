using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        // 1. Create a JSON object for a Student
        JObject student = new JObject
        {
            ["name"] = "John Doe",
            ["age"] = 20,
            ["subjects"] = new JArray("Math", "Science", "History")
        };
        Console.WriteLine("Student JSON:");
        Console.WriteLine(student.ToString());

        // 2. Convert a C# object (Car class) into JSON format
        Car car = new Car { Brand = "Toyota", Model = "Camry", Year = 2023 };
        string carJson = JsonConvert.SerializeObject(car, Formatting.Indented);
        Console.WriteLine("Car JSON:");
        Console.WriteLine(carJson);

        // 3. Read a JSON file and extract only specific fields (name, email)
        string jsonData = File.ReadAllText("data.json"); // Assume data.json contains an array of user objects
        JArray users = JArray.Parse(jsonData);
        foreach (JObject user in users)
        {
            Console.WriteLine("Name: " + user["name"]);
            Console.WriteLine("Email: " + user["email"]);
        }

        // 4. Merge two JSON objects into one
        JObject obj1 = new JObject { ["key1"] = "value1", ["key2"] = "value2" };
        JObject obj2 = new JObject { ["key3"] = "value3", ["key4"] = "value4" };
        obj1.Merge(obj2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Concat });
        Console.WriteLine("Merged JSON:");
        Console.WriteLine(obj1.ToString());

        // 5. Validate JSON structure using Newtonsoft.Json.Schema
        string jsonSchema = "{ \"type\": \"object\", \"properties\": { \"name\": { \"type\": \"string\" }, \"age\": { \"type\": \"integer\" } }, \"required\": [\"name\", \"age\"] }";
        JSchema schema = JSchema.Parse(jsonSchema);
        bool isValid = student.IsValid(schema);
        Console.WriteLine("Is Student JSON valid?: " + isValid);

        // 6. Convert a list of C# objects into a JSON array
        List<Car> carList = new List<Car>
        {
            new Car { Brand = "Honda", Model = "Civic", Year = 2020 },
            new Car { Brand = "Ford", Model = "Focus", Year = 2019 }
        };
        string carListJson = JsonConvert.SerializeObject(carList, Formatting.Indented);
        Console.WriteLine("Car List JSON:");
        Console.WriteLine(carListJson);

        // 7. Parse JSON and filter only those records where age > 25
        foreach (JObject user in users)
        {
            if (user.ContainsKey("age") && user["age"].Type == JTokenType.Integer && (int)user["age"] > 25)
            {
                Console.WriteLine("Filtered User: " + user.ToString());
            }
        }
    }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}