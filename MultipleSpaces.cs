using System;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        string text = "This   is  an   example   with    multiple   spaces.";
        string pattern = @"\s+";
        
        string result = Regex.Replace(text, pattern, " ");
        
        Console.WriteLine(result);
    }
}
