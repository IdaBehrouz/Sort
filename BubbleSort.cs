using System;
using System.Collections.Generic;

namespace ClassLibrary;

public interface ISortable1
{
    List<int> SortAscending(List<int> numbers);
    List<int> SortDescending(List<int> numbers);
}

public class BubbleSorter : ISortable1
{
    public List<int> SortAscending(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            for (int j = 0; j < numbers.Count - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
        return numbers;
    }

    public List<int> SortDescending(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            for (int j = 0; j < numbers.Count - 1 - i; j++)
            {
                if (numbers[j] < numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
        return numbers;
    }
}

