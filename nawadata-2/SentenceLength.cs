using System.Text.RegularExpressions;

namespace nawadata_2;

public class SentenceLength
{
    public void LengthOfSentence(string sentence)
    {
        
        var sentences = Regex.Split(sentence, @"[,\s]+");
        Console.WriteLine($"Jumlah kata dalam kalimat '{sentence}' adalah {sentences.Length} kata");
    }
}