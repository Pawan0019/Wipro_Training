using System;

class HeapSort
{
    static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        heapSort(arr);

        Console.WriteLine("\nSorted Array:");
        PrintArray(arr);
    }

    static void heapSort(int[] arr)
    {
        int n = arr.Length;

        // Step 1: Build Max Heap
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        // Step 2: Extract elements one by one
        for (int i = n - 1; i > 0; i--)
        {
            Swap(arr, 0, i);      // Move current root to end
            Heapify(arr, i, 0);   // Heapify reduced heap
        }
    }

    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            Swap(arr, i, largest);
            Heapify(arr, n, largest);
        }
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
