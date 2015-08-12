//Problem 2. Binary to decimal
//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string x = Console.ReadLine();

        Console.WriteLine(ConvertBinaryToDecimal(x));
    }

    private static long ConvertBinaryToDecimal(string x)
    {
        long num = 0;
        for (int i = 0; i < x.Length; i++)
        {
            int digit = x[i] - '0';
            num += digit*(long)Math.Pow(2,x.Length - i - 1);
        }
        
        return num;
    }
}

