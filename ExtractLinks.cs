using System;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        string text = "Visit https://www.google.com and http://example.org for more info.";
        string pattern = @"https?://[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(/\S*)?";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches) {
            Console.Write(match.Value + ", ");
        }
    }
}
