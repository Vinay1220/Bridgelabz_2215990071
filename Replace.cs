using System;

class Replace
{
    static void Main()
    {
        string sentence = "The quick brown fox jumps over the lazy dog.";
        string wordToReplace = "fox";
        string replacementWord = "cat";

        string result = ReplaceWordInSentence(sentence, wordToReplace, replacementWord);
        Console.WriteLine(result);
    }

    static string ReplaceWordInSentence(string sentence, string wordToReplace, string replacementWord)
    {
        // Replace the word only if it exists in the sentence
        return sentence.Replace(wordToReplace, replacementWord);
    }
}
