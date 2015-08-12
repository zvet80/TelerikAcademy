//Problem 1. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//a)
/*    a)					b)					c)					d)*
1	5	9	13		1	8	9	16		7	11	14	16		1	12	11	10
2	6	10	14		2	7	10	15		4	8	12	15		2	13	16	9
3	7	11	15		3	6	11	14		2	5	9	13		3	14	15	8
4	8	12	16		4	5	12	13		1	3	6	10		4	5	6	7
*/


using System;

class FillTheMatrix
{
   

    private static void PrintMatrixA(int[,] matrix)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void GenerateMatrixC(ref int[,] matrix)
    {
        int count = 0;
        int N = matrix.GetLength(0);

        for (int k = N - 1; k >= 0; --k)
            for (int i = k; i < N; ++i )
            {
                count++;
                matrix[i, i-k] = count;
            }

        for (int k = 1; k < N; ++k)
            for (int i = 0; i < N-k; ++i)
            {
                count++;
                matrix[i, k + i] = count;
            }
    }


    private static void GenerateMatrixB(ref int[,] matrix)
    {
        int count = 0;
        int row = 0;
        int[] steps = { -1, 1 };
        bool direction = false;
        int N = matrix.GetLength(0);
        int M = matrix.GetLength(0);

        for (int col = 0; col < N; col++)
        {
            // get one more step in the previous direction in order to stay on the same row when directions switch
            row += steps[Convert.ToInt32(direction)];
            direction = !direction;
            int step = steps[Convert.ToInt32(direction)];

            for (int i = 0; i < M; i++)
            {
                count++;
                row += step;
                matrix[row, col] = count;
            }
        }
    }
    private static void PrintMatrix(ref int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int i = 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = i;
                i++;
                
            }
           
        }
        PrintMatrixA(matrix);
        Console.WriteLine();
        GenerateMatrixB(ref matrix);
        PrintMatrix(ref matrix);
        Console.WriteLine();

        GenerateMatrixC(ref matrix);
        PrintMatrix(ref matrix);
        Console.WriteLine();
      
        Console.WriteLine();
        

    }
}

