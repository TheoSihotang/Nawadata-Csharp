namespace nawadata_2;

public class FindLetter
{
    public void Letter(string letter)
    {
        var mostLetter = ' ';
            for (int i = 0; i < letter.Length; i++)
            {
                for (var j = i+1; j < letter.Length; j++)
                {
                    if (letter[i] == letter[j])
                    {
                        mostLetter = letter[i];
                    }
                }
            }
        
        Console.WriteLine(mostLetter);
    }
}