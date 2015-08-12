//Problem 7. Reverse number
//Write a method that reverses the digits of given decimal number.
//Example:
//input	output
//256	652
//123.45	54.321

using System;

class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number: ");
        decimal x = decimal.Parse(Console.ReadLine());

        Console.WriteLine(ReverseDigits(x));
    }

    private static decimal ReverseDigits(decimal x)
    {
        char[] y = x.ToString().ToCharArray();
        Array.Reverse(y);
        return Convert.ToDecimal(new string(y));            
    }
}

