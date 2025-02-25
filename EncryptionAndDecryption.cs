using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class CsvEncryption
{
    static string encryptionKey = "your-encryption-key";

    static void Main()
    {
        string csvFilePath = "employee_data.csv";
        string encryptedCsvFilePath = "encrypted_employee_data.csv";
        string decryptedCsvFilePath = "decrypted_employee_data.csv";

        WriteEncryptedCsv(csvFilePath, encryptedCsvFilePath);
        ReadAndDecryptCsv(encryptedCsvFilePath, decryptedCsvFilePath);
    }

    public static void WriteEncryptedCsv(string csvFilePath, string encryptedCsvFilePath)
    {
        try
        {
            string[] employees = {
                "101,John Doe,HR,50000,john.doe@example.com",
                "102,Jane Smith,IT,60000,jane.smith@example.com",
                "103,Mike Brown,Marketing,55000,mike.brown@example.com"
            };

            using (StreamWriter writer = new StreamWriter(encryptedCsvFilePath))
            {
                writer.WriteLine("ID,Name,Department,Salary,Email");

                foreach (string employee in employees)
                {
                    string[] fields = employee.Split(',');

                    string encryptedSalary = Encrypt(fields[3]);
                    string encryptedEmail = Encrypt(fields[4]);

                    writer.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + encryptedSalary + "," + encryptedEmail);
                }
            }

            Console.WriteLine("Encrypted CSV file written successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error writing encrypted CSV: " + e.Message);
        }
    }

    public static void ReadAndDecryptCsv(string encryptedCsvFilePath, string decryptedCsvFilePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(encryptedCsvFilePath))
            using (StreamWriter writer = new StreamWriter(decryptedCsvFilePath))
            {
                string header = reader.ReadLine();
                writer.WriteLine(header);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');

                    string decryptedSalary = Decrypt(fields[3]);
                    string decryptedEmail = Decrypt(fields[4]);

                    writer.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + decryptedSalary + "," + decryptedEmail);
                }
            }

            Console.WriteLine("Decrypted CSV file written successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error reading or decrypting CSV: " + e.Message);
        }
    }

    public static string Encrypt(string plainText)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(encryptionKey);
            aesAlg.IV = new byte[16];

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            byte[] encrypted = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(plainText), 0, plainText.Length);
            return Convert.ToBase64String(encrypted);
        }
    }

    public static string Decrypt(string encryptedText)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(encryptionKey);
            aesAlg.IV = new byte[16];

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            byte[] decrypted = decryptor.TransformFinalBlock(Convert.FromBase64String(encryptedText), 0, Convert.FromBase64String(encryptedText).Length);
            return Encoding.UTF8.GetString(decrypted);
        }
    }
}