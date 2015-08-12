//Problem 6. Binary to hexadecimal
//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;


class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string x = Console.ReadLine();
        string bin = x.PadLeft(4 - x.Length % 4 + x.Length, '0');

        Console.WriteLine(ConvertBinToHex(bin));
    }

    private static string ConvertBinToHex(string x)
    {
        string num = "";
        string digit = "";

        for (int i = 0; i <x.Length ; i = i + 4)
        {
            digit = x.Substring(i, 4);

            switch (digit)
            {
                case "0000": num = num +'0'; break;
                case "0001": num = num + '1'; break;
                case "0010": num = num + '2'; break;
                case "0011": num = num + '3'; break;
                case "0100": num = num + '4'; break;
                case "0101": num = num + '5'; break;
                case "0110": num = num + '6'; break;
                case "0111": num = num + '7'; break;
                case "1000": num = num + '8'; break;
                case "1001": num = num + '9'; break;
                case "1010": num = num + 'A'; break;
                case "1011": num = num + 'B'; break;
                case "1100": num = num + 'C'; break;
                case "1101": num = num + 'D'; break;
                case "1110": num = num + 'E'; break;
                case "1111": num = num + 'F'; break;
            }
        }
        return num;
    }
}

