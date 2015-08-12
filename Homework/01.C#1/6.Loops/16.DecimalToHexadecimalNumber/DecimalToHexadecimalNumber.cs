//Problem 16. Decimal to Hexadecimal Number
//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        long x = long.Parse(Console.ReadLine());
        int digit = 0;
        string letter = "";
        string hex = "";
        while (x != 0)
        {
            digit = (int)((x % 16));

            if (digit <= 9)
            {
                hex = digit + hex;
            }
            else
            {
                letter = digit.ToString();
                switch (letter)
                {
                    case "10": letter = "A"; break;
                    case "11": letter = "B"; break;
                    case "12": letter = "C"; break;
                    case "13": letter = "D"; break;
                    case "14": letter = "E"; break;
                    case "15": letter = "F"; break;
                }
                hex = letter + hex;
            }
            x = x / 16;
        }
        Console.WriteLine(hex);
    }
}

