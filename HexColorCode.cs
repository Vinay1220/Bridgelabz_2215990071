using System;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        string pattern = @"^#[A-Fa-f0-9]{6}$";
        string[] colors = { "#FFA500", "#ff4500", "#123", "#ABCDEF", "#a1b2c3", "#GGG123" };

        foreach (string color in colors) {
            bool isValid = Regex.IsMatch(color, pattern);
            Console.WriteLine(color + ": " + (isValid ? "Valid" : "Invalid"));
        }
    }
}
