//Problem 1. Decimal to binary
//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine(ConvertDecimalToBinary(x));
    }

    private static string ConvertDecimalToBinary(int x)
    {
        string num = "";
        while (x > 0)
        {
            int digit = x % 2;
            num += digit.ToString();
            x /= 2;
        }
        char[] digits = num.ToCharArray();
        Array.Reverse(digits);
        return num = new string(digits);
    }
}

