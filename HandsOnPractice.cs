using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        // 1. Read a JSON file and print all keys and values
        string jsonData = File.ReadAllText("data.json");
        JObject jsonObject = JObject.Parse(jsonData);
        foreach (var pair in jsonObject)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }

        // 2. Convert a list of C# objects into a JSON array
        List<Car> carList = new List<Car>
        {
            new Car { Brand = "Honda", Model = "Civic", Year = 2020 },
            new Car { Brand = "Ford", Model = "Focus", Year = 2019 }
        };
        string carListJson = JsonConvert.SerializeObject(carList, Formatting.Indented);
        Console.WriteLine("Car List JSON:");
        Console.WriteLine(carListJson);

        // 3. Filter JSON data: Print only users older than 25 years
        JArray users = JArray.Parse(jsonData);
        foreach (JObject user in users)
        {
            if (user.ContainsKey("age") && user["age"].Type == JTokenType.Integer && (int)user["age"] > 25)
            {
                Console.WriteLine("Filtered User: " + user.ToString());
            }
        }

        // 4. Validate an email field using JSON Schema
        string jsonSchema = "{ \"type\": \"object\", \"properties\": { \"email\": { \"type\": \"string\", \"format\": \"email\" } }, \"required\": [\"email\"] }";
        JSchema schema = JSchema.Parse(jsonSchema);
        foreach (JObject user in users)
        {
            bool isValid = user.IsValid(schema);
            Console.WriteLine("Email Valid: " + isValid);
        }

        // 5. Merge two JSON files into a single JSON object
        string jsonData2 = File.ReadAllText("data2.json");
        JObject jsonObject2 = JObject.Parse(jsonData2);
        jsonObject.Merge(jsonObject2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Concat });
        Console.WriteLine("Merged JSON:");
        Console.WriteLine(jsonObject.ToString());

        // 6. Convert JSON to XML format
        XDocument xml = JsonConvert.DeserializeXNode(jsonData, "Root");
        Console.WriteLine("Converted XML:");
        Console.WriteLine(xml.ToString());

        // 7. Convert CSV data into JSON
        string csvData = File.ReadAllText("data.csv");
        string[] lines = csvData.Split('\n');
        string[] headers = lines[0].Split(',');
        JArray csvJsonArray = new JArray();
        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(',');
            JObject csvJson = new JObject();
            for (int j = 0; j < headers.Length; j++)
            {
                csvJson[headers[j]] = values[j];
            }
            csvJsonArray.Add(csvJson);
        }
        Console.WriteLine("CSV to JSON:");
        Console.WriteLine(csvJsonArray.ToString());

        // 8. Generate a JSON report from database records (Mock Data)
        List<Dictionary<string, object>> databaseRecords = new List<Dictionary<string, object>>
        {
            new Dictionary<string, object> { { "ID", 1 }, { "Name", "Alice" }, { "Age", 30 } },
            new Dictionary<string, object> { { "ID", 2 }, { "Name", "Bob" }, { "Age", 28 } }
        };
        string dbJson = JsonConvert.SerializeObject(databaseRecords, Formatting.Indented);
        Console.WriteLine("Database JSON Report:");
        Console.WriteLine(dbJson);
    }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}