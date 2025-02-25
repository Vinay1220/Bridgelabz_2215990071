using System;
using System.IO;

class LargeCSVReader
{
    static void Main()
    {
        string filePath = "largefile.csv";
        int chunkSize = 100;
        int processedRecords = 0;

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

                    processedRecords++;

                    if (processedRecords % chunkSize == 0)
                    {
                        Console.WriteLine("Processed {0} records.", processedRecords);
                    }
                }
            }

            Console.WriteLine("Total records processed: " + processedRecords);
        }
        catch (IOException e)
        {
            Console.WriteLine("Error reading the file: " + e.Message);
        }
    }
}