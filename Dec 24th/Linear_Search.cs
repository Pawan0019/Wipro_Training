class Linear_Search
{
    static void Main()
    {
        int[] arr = { 3, 7, 2, 9, 5 };
        int target = 9;
        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine("Element found");
        else
            Console.WriteLine("Element not found");
    }
}