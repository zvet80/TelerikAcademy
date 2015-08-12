//Problem 9. Frequent number
//Write a program that finds the most frequent number in an array.


using System;

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by comma:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(','), int.Parse);
        int count = 1;
        int maxCount = 0;
        int max = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
                if (maxCount < count)
                {
                    max = arr[i];
                    maxCount = count;
                }
            }
            count = 1;
        }
        if (maxCount == 1)
        {
            Console.WriteLine("all elements are unique");
        }
        else
        {
            Console.WriteLine("most frequent number: {0} ({1} times)", max, maxCount);
        }
    }
}

