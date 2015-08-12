//Problem 13. Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter binary number: ");        
        string x = Console.ReadLine();
        long sum = 0;        
        int n = x.Length;

        for (int i = 0; i < x.Length; i++)
        {
            int y = Convert.ToInt32((x[i]).ToString());
            sum += y * (long)Math.Pow(2, n-1);            
            n--;       
        }
        Console.WriteLine(sum);        
    }
}

