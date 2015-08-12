using System;

public class ExamTask1
{
    public const int BaseToConvert = 19;

    static void Main()
    {
        string[] input = Console.ReadLine().Trim().Split(' ');

        int decimalNum = ConvertBaseToDecimal(input);
        string baseNum = ConvertDecimalToBase(ConvertBaseToDecimal(input));

        Console.WriteLine("{0} = {1}", baseNum, decimalNum);
    }

    private static string ConvertDecimalToBase(int decimalNum)
    {
        string baseNum = string.Empty;

        while (decimalNum > 0)
        {
            int digit = 0;
            digit = decimalNum % BaseToConvert;

            baseNum = (char)(digit + 'a') + baseNum;

            decimalNum /= BaseToConvert;
        }

        return baseNum;
    }

    private static int ConvertBaseToDecimal(string[] input)
    {
        char[] baseChars = GenerateBaseChars(BaseToConvert);

        int numDecimal = 0;
        int temp = 0;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = input[i].Length - 1; j >= 0; j--)
            {
                int charPosition = Array.IndexOf(baseChars, input[i][j]);
                int baseMiltiplication = (int)Math.Pow(BaseToConvert, input[i].Length - 1 - j);
                temp += charPosition * baseMiltiplication;
            }

            numDecimal += temp;
            temp = 0;
        }

        return numDecimal;
    }

    private static char[] GenerateBaseChars(int inputBase)
    {
        char[] baseChars = new char[inputBase];

        for (int i = baseChars.Length - 1; i >= 0; i--)
        {
            baseChars[i] = (char)('a' + i);
        }

        return baseChars;
    }
}
