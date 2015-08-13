//Problem 8. Number as array
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        Console.WriteLine("Enter integer number: ");
        int[] arrX = Console.ReadLine().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
        Console.WriteLine("Enter another integer number: ");
        int[] arrY = Console.ReadLine().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();

        Array.Reverse(arrX);
        Array.Reverse(arrY);

        if (arrX.Length <= arrY.Length)
        {
            Console.WriteLine(string.Join("", AddBigNumbers(arrX, arrY)));
        }
        else
        {
            Console.WriteLine(string.Join("", AddBigNumbers(arrY, arrX)));
        }
    }

    private static List<int> AddBigNumbers(int[] arrX, int[] arrY)
    {

        List<int> arrZ = new List<int>();
        int rest = 0;

        for (int i = 0; i < arrX.Length; i++)
        {
            arrZ.Add((arrX[i] + arrY[i] + rest) % 10);
            rest = (arrX[i] + arrY[i] + rest) / 10;
        }
        for (int j = arrX.Length; j < arrY.Length; j++)
        {
            arrZ.Add((arrY[j] + rest) % 10);
            rest = (arrY[j] + rest) / 10;
        }
        if (rest > 0)
        {
            arrZ.Add(rest);
        }
        arrZ.Reverse();
        return arrZ;
    }
}

