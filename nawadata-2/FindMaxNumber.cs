namespace nawadata_2;

public class FindMaxNumber
{
    // cara pertama
    public void FindMaxNumbers(int[] numbers)
    {
        if (numbers.Length < 1)
        {
            Console.WriteLine("Array kosong");
        }
        else
        {
            var max = numbers.Max();
            Console.WriteLine($"Nilai tertinggi dalam array ini adalah {max}");
        }
    } 
    
    // cara kedua
    public void FindNumbers(int[] numbers)
    {
        var max = numbers[0];
        if (numbers.Length < 1)
        {
            Console.WriteLine("Array kosong");
        }
        else
        {
            for (var i = 0; i < numbers.Length-1; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                
            }

            Console.WriteLine($"Nilai tertinggi dalam array ini adalah {max}");
        }
    }
}