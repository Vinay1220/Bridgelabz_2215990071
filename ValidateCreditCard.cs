using System;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        string[] cardNumbers = { "4111111111111111", "5105105105105100", "6011000990139424", "1234567812345678", "5212345678901234" };
        string pattern = @"^(4\d{15}|5[1-5]\d{14})$";

        foreach (string card in cardNumbers) {
            bool isValid = Regex.IsMatch(card, pattern);
            Console.WriteLine(card + ": " + (isValid ? "Valid" : "Invalid"));
        }
    }
}
