using System;
using System.Collections.Generic;

namespace ClassLibrary;

public interface ISortable3
{
    List<int> SortAscending(List<int> numbers);
    List<int> SortDescending(List<int> numbers);
}

public class MergeSorter : ISortable3
{
    public List<int> SortAscending(List<int> numbers)
    {
        return MergeSort(numbers, true);
    }

    public List<int> SortDescending(List<int> numbers)
    {
        return MergeSort(numbers, false);
    }

    private List<int> MergeSort(List<int> numbers, bool ascending)
    {
        if (numbers.Count <= 1)
        {
            return numbers;
        }

        int mid = numbers.Count / 2;
        List<int> left = numbers.GetRange(0, mid);
        List<int> right = numbers.GetRange(mid, numbers.Count - mid);

        left = MergeSort(left, ascending);
        right = MergeSort(right, ascending);

        return Merge(left, right, ascending);
    }

    private List<int> Merge(List<int> left, List<int> right, bool ascending)
    {
        List<int> merged = new List<int>();
        int leftIndex = 0, rightIndex = 0;

        while (leftIndex < left.Count && rightIndex < right.Count)
        {
            if ((ascending && left[leftIndex] < right[rightIndex]) || (!ascending && left[leftIndex] > right[rightIndex]))
            {
                merged.Add(left[leftIndex]);
                leftIndex++;
            }
            else
            {
                merged.Add(right[rightIndex]);
                rightIndex++;
            }
        }

        merged.AddRange(left.GetRange(leftIndex, left.Count - leftIndex));
        merged.AddRange(right.GetRange(rightIndex, right.Count - rightIndex));

        return merged;
    }
}

