using System;
using System.Collections.Generic;
using System.IO;

class DuplicateCSV
{
    static void Main()
    {
        string filePath = "students.csv";
        HashSet<string> seenIDs = new HashSet<string>();
        List<string> duplicates = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                bool isHeader = true;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] data = line.Split(',');
                    if (data.Length > 0)
                    {
                        string id = data[0];

                        if (seenIDs.Contains(id))
                        {
                            duplicates.Add(line);
                        }
                        else
                        {
                            seenIDs.Add(id);
                        }
                    }
                }
            }

            if (duplicates.Count > 0)
            {
                Console.WriteLine("Duplicate records found:");
                foreach (string duplicate in duplicates)
                {
                    Console.WriteLine(duplicate);
                }
            }
            else
            {
                Console.WriteLine("No duplicate records found.");
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Error reading the file: " + e.Message);
        }
    }
}