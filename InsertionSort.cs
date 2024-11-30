using System;
using System.Collections.Generic;

namespace ClassLibrary;

public interface ISortable2
{
    List<int> SortAscending(List<int> numbers);
    List<int> SortDescending(List<int> numbers);
}

public class InsertionSorter : ISortable2
{
    public List<int> SortAscending(List<int> numbers)
    {
        for (int i = 1; i < numbers.Count; i++)
        {
            int key = numbers[i];
            int j = i - 1;
            while (j >= 0 && numbers[j] > key)
            {
                numbers[j + 1] = numbers[j];
                j--;
            }
            numbers[j + 1] = key;
        }
        return numbers;
    }

    public List<int> SortDescending(List<int> numbers)
    {
        for (int i = 1; i < numbers.Count; i++)
        {
            int key = numbers[i];
            int j = i - 1;
            while (j >= 0 && numbers[j] < key)
            {
                numbers[j + 1] = numbers[j];
                j--;
            }
            numbers[j + 1] = key;
        }
        return numbers;
    }
}

