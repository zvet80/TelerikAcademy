//Problem 6. Maximal K sum
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKsum
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the size of the subarray:");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];     
        Console.WriteLine("Enter the elements of the array on a new line:");           
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        for (int i = arr.Length - 1; i >= arr.Length - k; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

