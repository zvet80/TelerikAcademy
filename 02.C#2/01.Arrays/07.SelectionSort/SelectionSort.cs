//Problem 7. Selection sort
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


using System;

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by comma:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(','), int.Parse);

        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
			{
			    if (arr[i] > arr[j])
                {
                    arr[i] = arr[i] - arr[j];
                    arr[j] = arr[j] + arr[i];
                    arr[i] = arr[j] - arr[i];
                }
			}            
        }
        Console.WriteLine("Sorted array: {0}", string.Join(",", arr));
    }
}

