using System;

class QuickSort
{
    static void Main()
    {
        int[] arr = { 10, 7, 8, 9, 1, 5 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        quickSort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nSorted Array:");
        PrintArray(arr);
    }

    static void quickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            quickSort(arr, low, pivotIndex - 1);   // left sub-array
            quickSort(arr, pivotIndex + 1, high);  // right sub-array
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];   // pivot element
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return i + 1;
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}