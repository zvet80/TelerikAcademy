//Problem 9. Sorting array
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by space:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        Console.WriteLine("Enter index: ");
        int index = int.Parse(Console.ReadLine());
        if (index < 0 || index >= arr.Length)
        {
            Console.WriteLine("Enter another index > 0 && < {0}", arr.Length);
            index = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The max number from index {0} in the array is {1}", index, MaxFromIndex(arr, index));

        SortArrayAsc(arr, true);
        Console.WriteLine("Sorted asc: " + string.Join(",", arr));
        SortArrayAsc(arr, false);
        Console.WriteLine("Sorted desc: " + string.Join(",", arr));
    }


    private static void SortArrayAsc(int[] arr, bool asc)
    {
        int temp;
        int index;

        for (int i = 0; i < arr.Length; i++)
        {
            temp = arr[i];
            index = Array.IndexOf(arr, MaxFromIndex(arr, i));
            arr[i] = MaxFromIndex(arr, i);
            arr[index] = temp;
        }

        if (asc == true)
        {
            Array.Reverse(arr);
        }
    }

    private static int MaxFromIndex(int[] arr, int index)
    {
        int maxNum = int.MinValue;
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] >= maxNum)
            {
                maxNum = arr[i];
            }
        }
        return maxNum;
    }
}

