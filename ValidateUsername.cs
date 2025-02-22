using System;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        string[] usernames = { "user_123", "123user", "us", "valid_user", "User99", "invalid-user" };

        foreach (string username in usernames) {
            bool isValid = Regex.IsMatch(username, pattern);
            Console.WriteLine(username + ": " + (isValid ? "Valid" : "Invalid"));
        }
    }
}
