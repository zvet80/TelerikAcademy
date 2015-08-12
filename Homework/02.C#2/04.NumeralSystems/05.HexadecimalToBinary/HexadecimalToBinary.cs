//Problem 5. Hexadecimal to binary
//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter a hex number: ");
        string x = Console.ReadLine().ToUpper();

        Console.WriteLine(ConvertHexToBin(x));
    }

    private static string ConvertHexToBin(string x)
    {
        string num = "";
        string digit = "";

        for (int i = 0; i < x.Length; i ++)
        {
            digit = x[i].ToString();

            switch (digit)
            {
                case "0": num = num + "0000"; break;
                case "1": num = num + "0001"; break;
                case "2": num = num + "0010"; break;
                case "3": num = num + "0011"; break;
                case "4": num = num + "0100"; break;
                case "5": num = num + "0101"; break;
                case "6": num = num + "0110"; break;
                case "7": num = num + "0111"; break;
                case "8": num = num + "1000"; break;
                case "9": num = num + "1001"; break;
                case "A": num = num + "1010"; break;
                case "B": num = num + "1011"; break;
                case "C": num = num + "1100"; break;
                case "D": num = num + "1101"; break;
                case "E": num = num + "1110"; break;
                case "F": num = num + "1111"; break;
            }
        }
        int index = num.IndexOf('1');
        return num.Substring(index);
    }
}

