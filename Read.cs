using System;
using System.IO;

class CSVReader
{
    static void Main()
    {
        string filePath = "students.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            bool isHeader = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader)
                {
                    isHeader = false;
                    continue;
                }

                string[] data = line.Split(',');

                foreach (string value in data)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine("----------------------");
            }
        }
    }
}