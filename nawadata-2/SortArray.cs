namespace nawadata_2;

public class SortArray
{
    // cara pertama
    public void ArraySort(int[] numbers)
    {
        Array.Sort(numbers);
        Console.WriteLine(String.Join(",", numbers));
    }
    
    // cara kedua
    public void SortArrayWithLoop(int[] numbers)
    {
        int temp;
        for (var i = 0; i < numbers.Length-1; i++)
        {
            for (var j = 0; j < numbers.Length-1; j++)
            {
                if (numbers[j] > numbers[j+1])
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine(String.Join(",", numbers));
    }
}