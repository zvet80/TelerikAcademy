//Problem 5. Maximal area sum
//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.


using System;
using System.IO;
using System.Linq;

class MaximalAreaSum
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        StreamWriter writer = new StreamWriter(@"..\..\ouput.txt");

        using (writer)
        {
            using (reader)
            {
                int n = int.Parse(reader.ReadLine());
                int[,] matrix = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    int[] lineNums = reader.ReadLine()
                        .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();

                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = lineNums[j];
                    }
                }
                writer.WriteLine(maxAreaSum(matrix));
            }

        }
        Console.WriteLine("ready");
    }
    static int maxAreaSum(int[,] x)
    {
        int sum = 0;
        int maxSum = int.MinValue;

        for (int r = 0; r < x.GetLength(0) - 1; r++)
        {
            for (int c = 0; c < x.GetLength(1) - 1; c++)
            {
                sum = x[r, c] + x[r + 1, c + 1] +
                    x[r, c + 1] + x[r + 1, c];

                if (maxSum < sum)
                {
                    maxSum = sum;
                }
                sum = 0;
            }
        }
        return maxSum;
    }
}

