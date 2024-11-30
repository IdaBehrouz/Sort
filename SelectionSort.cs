using System;
using System.Collections.Generic;

namespace ClassLibrary;

public interface ISortable
{
    List<int> SortAscending(List<int> numbers);
    List<int> SortDescending(List<int> numbers);
}

public class SelectionSorter : ISortable
{
    public List<int> SortAscending(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
        }
        return numbers;
    }

    public List<int> SortDescending(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[j] > numbers[maxIndex])
                {
                    maxIndex = j;
                }
            }
            if (maxIndex != i)
            {
                int temp = numbers[i];
                numbers[i] = numbers[maxIndex];
                numbers[maxIndex] = temp;
            }
        }
        return numbers;
    }
}

