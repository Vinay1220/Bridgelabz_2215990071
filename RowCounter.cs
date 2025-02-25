using System;
using System.IO;

class CSVRowCounter
{
    static void Main()
    {
        string filePath = "data.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        int count = 0;
        using (StreamReader reader = new StreamReader(filePath))
        {
            bool isHeader = true;
            while (reader.ReadLine() != null)
            {
                if (isHeader)
                {
                    isHeader = false;
                    continue;
                }
                count++;
            }
        }

        Console.WriteLine("Total records: " + count);
    }
}