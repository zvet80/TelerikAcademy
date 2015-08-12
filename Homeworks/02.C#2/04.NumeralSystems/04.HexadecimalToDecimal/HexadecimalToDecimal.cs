//Problem 4. Hexadecimal to decimal
//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal number: ");
        string x = Console.ReadLine().ToUpper();

        Console.WriteLine(ConvertHexToDecimal(x));
    }

    private static long ConvertHexToDecimal(string x)
    {
        long num = 0;
        int digit = 0;

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] >= '0' && x[i] <= '9')
            {
                digit = x[i] - '0';
            }
            else
            {
                digit = x[i] - 'A' + 10;
            }

            num += digit * (long)Math.Pow(16, x.Length - i - 1);
        }

        return num;
    }
}

