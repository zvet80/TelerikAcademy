//Problem 15. Hexadecimal to Decimal Number
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal integer number: ");
        string x = Console.ReadLine().Trim().ToUpper();
        long sum = 0;
        int n = x.Length;
        long sixteen = 1;
        while (n > 0)
        {
            n--;
            string digit = x[n].ToString();
            switch (digit)
            {
                case "0": digit = "0"; break;
                case "1": digit = "1"; break;
                case "2": digit = "2"; break;
                case "3": digit = "3"; break;
                case "4": digit = "4"; break;
                case "5": digit = "5"; break;
                case "6": digit = "6"; break;
                case "7": digit = "7"; break;
                case "8": digit = "8"; break;
                case "9": digit = "9"; break;
                case "A": digit = "10"; break;
                case "B": digit = "11"; break;
                case "C": digit = "12"; break;
                case "D": digit = "13"; break;
                case "E": digit = "14"; break;
                case "F": digit = "15"; break;
                default: Console.WriteLine("wrong input");
                    break;
            }
            sum += long.Parse(digit) * sixteen;            
            sixteen *= 16;
        }
        Console.WriteLine(sum);
    }
}

