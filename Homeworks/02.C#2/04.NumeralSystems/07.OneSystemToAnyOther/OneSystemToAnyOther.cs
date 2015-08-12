//Problem 7. One system to any other
//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        string x = Console.ReadLine();
        Console.WriteLine("Enter its base: ");
        int numBase1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a conversion base: ");
        int numBase2 = int.Parse(Console.ReadLine());

        Console.WriteLine(ConvertDecimalToAny(ConvertAnyToDecimal(x, numBase1),numBase2));
    }

    private static string ConvertDecimalToAny(long x, int numBase)
    {
        string num = "";
        while (x > 0)
        {
            long digit = 0;
            digit = x % numBase;

            if (digit < 10)
            {
                num = digit.ToString() + num;
            }
            else
            {
                num = (char)(digit - 10 + 'A') + num;
            }
            x /= numBase;
        }

        return num;
    }
    private static long ConvertAnyToDecimal(string x, int numBase)
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

            num += digit * (long)Math.Pow(numBase, x.Length - i - 1);
        }

        return num;
    }
}

