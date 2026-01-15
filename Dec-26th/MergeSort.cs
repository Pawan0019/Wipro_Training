// ### Merge Sort Program in C#

using System;  // Provides basic input-output functionality
class Program
{
    static void Main()
    {
        // Declare and initialize the array to be sorted
        int[] arr = { 5, 3, 8, 4, 2 };

        // Call MergeSort on the full array (from index 0 to last index)
        MergeSort(arr, 0, arr.Length - 1);

        // Print the sorted array

        Console.WriteLine("Sorted Array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }

    // This method divides the array into smaller parts
    static void MergeSort(int[] arr, int left, int right)
    {
        // Continue dividing only if there is more than one element
        if (left < right)
        {
            // Find the middle index of the array
            int mid = (left + right) / 2;

            // Recursively sort the left half
            MergeSort(arr, left, mid);

            // Recursively sort the right half
            MergeSort(arr, mid + 1, right);

            // Merge the two sorted halves
            Merge(arr, left, mid, right);
        }
    }

    // This method merges two sorted subarrays into one sorted array
    static void Merge(int[] arr, int left, int mid, int right)
    {
        // Calculate sizes of the two subarrays
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Create temporary arrays to store left and right subarrays
        int[] L = new int[n1];
        int[] R = new int[n2];

        // Copy data into left subarray
        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];

        // Copy data into right subarray
        for (int j = 0; j < n2; j++)
            R[j] = arr[mid + 1 + j];

        // Index for left array
        int iIndex = 0;

        // Index for right array
        int jIndex = 0;

        // Index for merged array
        int k = left;

        // Compare elements from both subarrays and merge them in sorted order
        while (iIndex < n1 && jIndex < n2)
        {
            if (L[iIndex] <= R[jIndex])
            {
                arr[k] = L[iIndex];
                iIndex++;
            }
            else
            {
                arr[k] = R[jIndex];
                jIndex++;
            }
            k++;
        }

        // Copy any remaining elements from left subarray
        while (iIndex < n1)
        {
            arr[k] = L[iIndex];
            iIndex++;
            k++;
        }

        // Copy any remaining elements from right subarray
        while (jIndex < n2)
        {
            arr[k] = R[jIndex];
            jIndex++;
            k++;
        }
    }
}