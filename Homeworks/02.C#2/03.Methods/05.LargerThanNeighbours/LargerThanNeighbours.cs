//Problem 5. Larger than neighbours
//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).


using System;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by space:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        Console.WriteLine("Enter a position: ");
        int k = int.Parse(Console.ReadLine());

        if (k < 0 || k > arr.Length - 1)
        {
            Console.WriteLine("There is no such position in the array");
        }
        else if (k - 1 < 0 || k + 1 > arr.Length - 1)
        {
            Console.WriteLine("There are no two neighbours"); 
        }
        else
        {
            Console.WriteLine("The element at position {0} is larger than its neighbours: {1}", k, CheckNeighbours(arr, k));
        }
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

