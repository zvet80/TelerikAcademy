////Problem 14. Quick sort
////Write a program that sorts an array of integers using the Quick sort algorithm.

using System;

class QuickSort
{

    static public void Quick(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int pivot = arr[end];
            int pIndex = start;
            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    int temp = arr[i];
                    arr[i] = arr[pIndex];
                    arr[pIndex] = temp;
                    pIndex++;
                }
            }
            arr[end] = arr[pIndex];
            arr[pIndex] = pivot;
            Quick(arr, start, pIndex - 1);
            Quick(arr, pIndex + 1, end);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by comma:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(','), int.Parse);

        Quick(arr, 0, arr.Length - 1);
        Console.WriteLine(string.Join(",", arr));

    }
}


