//Problem 11. Binary search
//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.


using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by comma:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(','), int.Parse);
        Console.WriteLine("Enter an integer to find: ");
        int n = int.Parse(Console.ReadLine());
        bool found = false;
        int key = arr.Length / 2;
        int begin = 0;
        int end = arr.Length;

        Array.Sort(arr);

        while (begin != end)
        {
            if (arr[key] == n)
            {
                Console.WriteLine("the index of the integer is: {0}",key);
                found = true; break;
            }
            else if (n < arr[key])
            {
                end = key;
                key = key / 2;
            }
            else
            {
                begin = key + 1;
                key += (end - key) / 2;
            }
        }
        if (found == false)
        {
            Console.WriteLine("There is no such number in the array");
        }
    }
}

