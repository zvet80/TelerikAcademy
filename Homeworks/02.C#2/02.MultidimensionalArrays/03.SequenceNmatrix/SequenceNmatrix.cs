//Problem 3. Sequence n matrix
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class SequenceNmatrix
{
    static void Main()
    {
        Console.WriteLine("Enter height of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter width of the matrix: ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("matrix[{0},{1}]=", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }

        int count = 1;
        int maxCount = 0;
        string maxString = "";
        //horizontally
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1])
                {
                    count++;

                    if (maxCount < count)
                    {
                        maxCount = count;
                        maxString = matrix[i, j];
                    }
                }
                else count = 1;
            }
        }
        count = 1;
        //vertically
        for (int j  = 0; j < m-1; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] == matrix[i, j+1])
                {
                    count++;

                    if (maxCount < count)
                    {
                        maxCount = count;
                        maxString = matrix[i, j];
                    }
                }
                else count = 1;
            }
        }
        count = 1;
        //left diagonal
        for (int i = 0; i < n - 1 && i < m - 1; i++)
        {
            if (matrix[i, i] == matrix[i + 1, i + 1])
            {
                count++;

                if (maxCount < count)
                {
                    maxCount = count;
                    maxString = matrix[i, i];
                }
            }
            else count = 1;
        }
        count = 1;
        //right diagonal
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 0; j < m - 1; j++)
            {

                if (matrix[i, j] == matrix[i - 1, j + 1])
                {
                    count++;

                    if (maxCount < count)
                    {
                        maxCount = count;
                        maxString = matrix[i, i];
                    }
                }
                else count = 1;
            }
        }


        Console.WriteLine("The maximal sequence in:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("is:");
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write("{0} ", maxString);
        }
        Console.WriteLine();
    }
}

