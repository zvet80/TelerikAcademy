//Problem 2. Maximal sum
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.


using System;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter height of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter width of the matrix: ");
        int m = int.Parse(Console.ReadLine());        
        int[,] matrix = new int[n, m];
        int maxRow = 0;
        int maxCol = 0;
        int sum = 0;
        int maxSum = int.MinValue;

        if (m < 3 || n < 3)
        {
            Console.WriteLine("Enter height and width > 3");
        }
        else
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("matrix[{0},{1}]=", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int r = 0; r < matrix.GetLength(0) - 2; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 2; c++)
                {
                    sum = matrix[r, c] + matrix[r + 1, c + 1] + matrix[r + 2, c + 2] +
                        matrix[r, c + 1] + matrix[r + 1, c + 2] + matrix[r, c + 2] +
                        matrix[r + 1, c] + matrix[r + 2, c + 1] + matrix[r + 2, c];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        maxRow = r;
                        maxCol = c;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine("The matrix:");
            for (int i = maxRow; i < maxRow + 3; i++)
            {
                for (int j = maxCol; j < maxCol + 3; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("is with maxSum = {0}", maxSum);
        }
    }
}


