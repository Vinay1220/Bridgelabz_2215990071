using System;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        string[] ssnNumbers = { "123-45-6789", "123456789", "987-65-4321", "12-3456-789" };
        string pattern = @"^\d{3}-\d{2}-\d{4}$";

        foreach (string ssn in ssnNumbers) {
            bool isValid = Regex.IsMatch(ssn, pattern);
            Console.WriteLine($"\"{ssn}\" is " + (isValid ? "valid ✅" : "invalid ❌"));
        }
    }
}
