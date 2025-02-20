using System;
using System.IO;

class ImageByteArrayConversion
{
    static void Main()
    {
        string sourceImagePath = "source.jpg";
        string destinationImagePath = "copy.jpg";

        try
        {
            // Convert image to byte array
            byte[] imageBytes = FileToByteArray(sourceImagePath);

            // Write byte array back to image file
            ByteArrayToFile(destinationImagePath, imageBytes);

            Console.WriteLine("Image successfully converted to byte array and saved back.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static byte[] FileToByteArray(string filePath)
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (MemoryStream ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                return ms.ToArray();
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
            return new byte[0];
        }
    }

    static void ByteArrayToFile(string filePath, byte[] byteArray)
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                fs.Write(byteArray, 0, byteArray.Length);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error writing file: " + ex.Message);
        }
    }
}