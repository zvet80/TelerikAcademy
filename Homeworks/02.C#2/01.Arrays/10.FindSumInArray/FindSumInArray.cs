//Problem 10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:
//array	                S	result
//4, 3, 1, 4, 2, 5, 8   11	4, 2, 5

using System;
using System.Collections.Generic;

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by comma:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(','), int.Parse);
        Console.WriteLine("Enter sum: ");
        int sum = int.Parse(Console.ReadLine());
        int sumTemp = 0;
        bool found = false;
        List<int> sumArr = new List<int>();

        for (int i = 0; i < arr.Length - 1; i++)
        {
            sumTemp = arr[i];
            sumArr.Clear();
            sumArr.Add(arr[i]);

            for (int j = i + 1; j < arr.Length; j++)
            {
                sumArr.Add(arr[j]);
                sumTemp += arr[j];

                if (sumTemp == sum)
                {
                    Console.WriteLine("Subarray with sum {0}: {1}", sum, string.Join(",", sumArr));
                    found = true;
                }
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == sum)
            {
                Console.WriteLine("Subarray with sum {0}: {1}", sum, arr[i]);
                found = true;
            }
        }
        if (found == false)
        {
            Console.WriteLine("There is no subarray with sum {0}", sum);
        }

    }
}

