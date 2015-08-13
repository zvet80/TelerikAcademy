//Problem 4. Binary search
//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by comma:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(','), int.Parse);
        Console.WriteLine("Enter integer k:");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(arr);
        int index = (Array.BinarySearch(arr, k) > 0) ? Array.BinarySearch(arr, k) : ~Array.BinarySearch(arr, k) - 1;

        Console.WriteLine("The largest number <= {0} in the array is {1}", k, arr[index]);
    }
}

