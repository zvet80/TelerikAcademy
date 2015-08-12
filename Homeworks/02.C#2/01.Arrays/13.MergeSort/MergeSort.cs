//Problem 13.* Merge sort
//Write a program that sorts an array of integers using the Merge sort algorithm.


using System;

class MergeSort
{
    public static void SplitArr(int[] arr)
    {
        int n = arr.Length;
        if (n < 2) return;
        int mid = n / 2;
        int[] left = new int[mid];
        int[] right = new int[n - mid];

        for (int i = 0; i < mid; i++)
        {
            left[i] = arr[i];
        }
        for (int i = mid; i < n; i++)
        {
            right[i - mid] = arr[i];
        }
        SplitArr(left);
        SplitArr(right);
        Merge(left, right, arr);
    }

    static public void Merge(int[] left, int[] right, int[] arr)
    {
        int i = 0;
        int j = 0;
        int k = 0;

        while ((i < left.Length) && (j < right.Length))
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }
        while (i < left.Length)
        {
            arr[k] = left[i];
            i++; k++;
        }
        while (j < right.Length)
        {
            arr[k] = right[j];
            j++; k++;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by comma:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(','), int.Parse);

        SplitArr(arr);
        Console.WriteLine(string.Join(",", arr));        
    }
}