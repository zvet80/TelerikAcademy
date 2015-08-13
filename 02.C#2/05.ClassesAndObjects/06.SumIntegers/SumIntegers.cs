//Problem 6. Sum integers
//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter integers (separated by space): ");
        string nums = Console.ReadLine();

        Console.WriteLine("sum= {0}",CalcSum(nums));        
    }

    private static int CalcSum(string x)
    {
        int[] nums = Array.ConvertAll(x.Trim().Split(' '), int.Parse);
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum+=nums[i];
        }
        return sum;
    }
}

