using System;
using System.Linq;
using System.Numerics;

public class ExamTask2
{
    static void Main()
    {
        long[] input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        BigInteger result = 0;
        int index = 1;

        while (index < input.Length)
        {
            long absDifference = CalcAbsDifference(input[index], input[index - 1]);

            if (absDifference % 2 == 0)
            {
                index = index + 2;
            }
            else
            {
                result += absDifference;
                index = index + 1;
            }
        }

        Console.WriteLine(result);
    }

    static long CalcAbsDifference(long x, long y)
    {
        if (x > y)
        {
            return x - y;
        }
        else
        {
            return y - x;
        }
    }
}
