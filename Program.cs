using System;
using System.Collections.Generic;
using ClassLibrary;

public interface ISortable
{
    List<int> SortAscending(List<int> numbers);
    List<int> SortDescending(List<int> numbers);
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers =
        {
            34, 159, 96, 608, 897, 358, 135, 325, 595, 411, 564, 657, 279, 423, 599, 422,
            820, 546, 24, 133, 553, 405, 877, 281, 993, 387, 438, 672, 41, 43, 325, 89,
            183, 781, 538, 895, 42, 167, 669, 100, 324, 454, 452, 364, 928, 732, 923, 644,
            444, 727, 144, 307, 395, 381, 792, 58, 729, 933, 39, 149, 733, 823, 764, 245,
            305, 914, 578, 14, 692, 373, 507, 314, 236, 427, 116, 341, 766, 389, 912, 694,
            49, 866, 819, 104, 610, 655, 137, 883, 566, 986, 417, 163, 290, 83, 854, 192,
            91, 499, 342, 803
        };

        List<int> numberList = new List<int>(numbers);

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1-Bubble Sort");
        Console.WriteLine("2-Insertion Sort");
        Console.WriteLine("3-Selection Sort");
        Console.WriteLine("4-Merge Sort");

        int choice = int.Parse(Console.ReadLine());

        //you can convert the ascending and descending methods to have another order

        switch (choice)
        {
            case 1:
                BubbleSorter bubbleSorter = new BubbleSorter();
                PrintSortedList(bubbleSorter.SortDescending(numberList));
                break;

            case 2:
                InsertionSorter insertionSorter = new InsertionSorter();
                PrintSortedList(insertionSorter.SortAscending(numberList));
                break;

            case 3:
                SelectionSorter selectionSorter = new SelectionSorter();
                PrintSortedList(selectionSorter.SortDescending(numberList)); 
                break;

            case 4:
                MergeSorter mergeSorter = new MergeSorter();
                PrintSortedList(mergeSorter.SortAscending(numberList)); 
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }

    static void PrintSortedList(List<int> sortedList)
    {
        Console.WriteLine(string.Join(", ", sortedList));
    }
}
