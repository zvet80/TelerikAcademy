//Problem 8. Maximal sum
////Write a program that finds the sequence of maximal sum in given array.
//Example:
//input	                                    result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	        2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?


using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by comma:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(','), int.Parse);
        int sumTemp = 0;
        int maxSum = 0;
        List<int> SumTempArr = new List<int>();
        List<int> maxSumArr = new List<int>();

        if (arr.Max() <= 0)
        {
            Console.WriteLine("Sub array with maximal sum: {0}", arr.Max());
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (sumTemp + arr[i] > 0)
                {
                    SumTempArr.Add(arr[i]);
                    sumTemp += arr[i];
                }
                else
                {
                    sumTemp = 0;
                    SumTempArr.Clear();
                }

                if (maxSum < sumTemp)
                {
                    maxSum = sumTemp;
                    maxSumArr.Clear();
                    maxSumArr.AddRange(SumTempArr);
                }
            }
            Console.WriteLine("Sub array with maximal sum: {0}", string.Join(",", maxSumArr));
        }
    }
}

