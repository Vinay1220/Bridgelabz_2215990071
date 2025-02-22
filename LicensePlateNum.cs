using System;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        string pattern = @"^[A-Z]{2}\d{4}$";
        string[] plates = { "AB1234", "A12345", "XY9876", "AB12CD", "ZZ9999" };

        foreach (string plate in plates) {
            bool isValid = Regex.IsMatch(plate, pattern);
            Console.WriteLine(plate + ": " + (isValid ? "Valid" : "Invalid"));
        }
    }
}
