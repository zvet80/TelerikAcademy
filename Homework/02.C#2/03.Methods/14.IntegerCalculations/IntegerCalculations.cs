//Problem 14. Integer calculations
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers,separated by space:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);

        CalcMin(arr);
        CalcMax(arr);
        CalcAvg(arr);
        CalcSum(arr);
        CalcProduct(arr);
    }

    private static void CalcMin(int[] arr)
    {
        int minNum = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]<minNum)
            {
                minNum = arr[i];
            }
        }
        Console.WriteLine("The minNum is: {0}",minNum);
    }

    private static void CalcMax(int[] arr)
    {
        int maxNum = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxNum)
            {
                maxNum = arr[i];
            }
        }
        Console.WriteLine("The maxNum is: {0}", maxNum);
    }

    private static void CalcAvg(int[] arr)
    {
        double sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        double avg = sum / arr.Length;
        Console.WriteLine("The average of the numbers is: {0:F2}", avg);
    }

    private static void CalcSum(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        
        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }

    private static void CalcProduct(int[] arr)
    {
        int product = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }

        Console.WriteLine("The product of the numbers is: {0}", product);
    }
}

