using System;
using System.Diagnostics;
using System.IO;

class BufferedFileCopy
{
    static void Main()
    {
        string sourceFile = "largefile.dat";
        string destinationFileBuffered = "destination_buffered.dat";
        string destinationFileUnbuffered = "destination_unbuffered.dat";
        int bufferSize = 4096;

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();

            // Buffered Stream Copy
            stopwatch.Start();
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (BufferedStream bsRead = new BufferedStream(fsRead, bufferSize))
            using (FileStream fsWrite = new FileStream(destinationFileBuffered, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite, bufferSize))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bsWrite.Write(buffer, 0, bytesRead);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Buffered copy time: " + stopwatch.ElapsedMilliseconds + " ms");

            // Unbuffered Stream Copy
            stopwatch.Reset();
            stopwatch.Start();
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destinationFileUnbuffered, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Unbuffered copy time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
