//Problem 15. Prime numbers
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {        
        int[] arr = new int[10000000];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
        for (int i = 2; i < Math.Sqrt(arr.Length); i++)
        {
            if (arr[i] !=0)
            {
                for (int j = i * i; j < arr.Length; j = j + i)
                {
                    arr[j] = 0;
                }
            }
        }
        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] !=0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

