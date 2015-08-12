//Problem 3. Decimal to hexadecimal
//Write a program to convert decimal numbers to their hexadecimal representation.


using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine(ConvertDecimalToHex(x));
    }

    private static string ConvertDecimalToHex(int x)
    {
        string num = "";
        while (x > 0)
        {
            int digit = 0;
            digit = x % 16;

            if (digit < 10)
            {
                num = digit.ToString() + num;
            }
            else
            {
                num = (char)(digit - 10 + 'A') + num;
            }
            x /= 16;
        }

        return num;
    }
}

