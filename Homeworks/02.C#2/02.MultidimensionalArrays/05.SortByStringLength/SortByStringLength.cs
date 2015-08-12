//Problem 5. Sort by string length
//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortByStringLength
{
    static void Main()
    {
        Console.WriteLine("Enter array of strings(separated by comma):");
        string[] arr = Console.ReadLine().Trim().Split(',');

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i].Length>arr[j].Length)
                {
                    string temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;                   
                }
            }
        }

        Console.WriteLine("Sorted array: {0}", string.Join(",", arr));
    }
}

