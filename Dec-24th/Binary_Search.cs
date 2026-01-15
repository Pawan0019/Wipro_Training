using System;
class Binary_Search
{
    public static void Main()
    {
        // IMPORTANT: Array must be sorted
        int[] arr=  {3, 5, 7, 9, 11, 13};
        int target = 7;

        bool found = false;
        int low = 0;
        int high = arr.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            
            if (arr[mid] == target)
            {
                found = true;
                break;
            }
            else if (target < arr[mid])
            {
                high = mid-1;
            }
            else
            {
            low = mid + 1;        
            }
        }
        if (found){Console.WriteLine("Element found");}
        else{Console.WriteLine("Element not found");}
    }
}