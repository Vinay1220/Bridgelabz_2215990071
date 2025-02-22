using System;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        string text = "This is a damn bad example with some stupid words.";
        string[] badWords = { "damn", "stupid" };
        string pattern = @"\b(" + string.Join("|", badWords) + @")\b";

        string result = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
        
        Console.WriteLine(result);
    }
}
