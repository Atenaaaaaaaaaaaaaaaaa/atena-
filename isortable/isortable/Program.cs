using System;
using isortable.bubble_sort;
using isortable.merch_sort;
using isortable.insert_sort;
using isortable.selection_sort;
using isortable;

class Program
{
    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original Array:");
        PrintArray(array);

        Console.WriteLine("\nBubble Sort:");
        int[] bubbleSorted = (int[])array.Clone();
        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.Sort(bubbleSorted);
        PrintArray(bubbleSorted);

        Console.WriteLine("\nMerge Sort:");
        int[] mergeSorted = (int[])array.Clone();
        MergeSort mergeSort = new MergeSort();
        mergeSort.Sort(mergeSorted); 
        PrintArray(mergeSorted);

        Console.WriteLine("\nInsertion Sort:");
        int[] insertionSorted = (int[])array.Clone();
        InsertSort insertSort = new InsertSort();
        insertSort.Sort(insertionSorted);
        PrintArray(insertionSorted);

        Console.WriteLine("\nSelection Sort:");
        int[] selectionSorted = (int[])array.Clone();
        SelectionSort selectionSort = new SelectionSort();
        selectionSort.Sort(selectionSorted);
        PrintArray(selectionSorted);
    }
}
