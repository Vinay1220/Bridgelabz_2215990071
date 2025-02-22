using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program {
    static void Main() {
        string text = "This is is a repeated repeated word test.";
        string pattern = @"\b(\w+)\b\s+\b\1\b";  

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
        HashSet<string> uniqueWords = new HashSet<string>();  

        foreach (Match match in matches) {
            uniqueWords.Add(match.Groups[1].Value);
        }

        Console.WriteLine(string.Join(", ", uniqueWords));
    }
}
