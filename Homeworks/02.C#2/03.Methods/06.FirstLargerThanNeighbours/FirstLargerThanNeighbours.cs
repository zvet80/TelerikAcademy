//Problem 6. First larger than neighbours
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by space:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                
        Console.WriteLine(CheckFirst(arr));
    }

    private static int CheckFirst(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (CheckNeighbours(arr, i))
            {
                return i;
            }
        }
        return -1;
    }

    private static bool CheckNeighbours(int[] arr, int k)
    {

        if (arr[k] > arr[k - 1] && arr[k] > arr[k + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

