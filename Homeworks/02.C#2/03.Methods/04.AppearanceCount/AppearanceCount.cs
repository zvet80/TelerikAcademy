//Problem 4. Appearance count
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers, separated by space:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        Console.WriteLine("Enter a number: ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("The number {0} appears {1} times in the array", k, CountK(arr, k));
        //Console.WriteLine(CheckCountK());
    }

    private static int CountK(int[] arr, int k)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == k)
            {
                count++;
            }
        }
        return count;
    }

    private static bool CheckCountK()
    {
        int[] arrTest = {1,6,1,1,1,2};
        int k = 1;
        int[] arrTest1 = {2,3};

        if (CountK(arrTest,k)==4 && CountK(arrTest1,k)==0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }    
}

