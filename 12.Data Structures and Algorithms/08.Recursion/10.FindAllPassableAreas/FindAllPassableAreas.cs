namespace _10.FindAllPassableAreas
{
    /*10*We are given a matrix of passable and non-passable cells.
        Write a recursive program for finding all areas of passable cells in the matrix.*/

    using System;
    using System.Collections.Generic;

    public class LargestArea
    {
        private static int n = 5;
        private static int m = 6;
        //empty cells = 0, unreachable cells = 1;
        private static double percentUnreachableCells = 0.6;

        public static void Main()
        {
            int[,] matrix = GenerateMatrix(n, m);
            PrintMatrix(matrix);
            FindAllPassableAreas(matrix);
        }

        private static void FindAllPassableAreas(int[,] matrix)
        {
            int currentCount = 0;
            List<Tuple<int, int>> currentArea = new List<Tuple<int, int>>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    FindArea(matrix, i, j, ref currentCount, ref currentArea);

                    if (currentCount >0)
                    {
                        PrintArea(currentArea);
                    }

                    currentArea.Clear();
                    currentCount = 0;
                }
            }
        }

        private static void FindArea(int[,] matrix, int row, int col, ref int count, ref List<Tuple<int, int>> area)
        {
            if (!InRange(matrix, row, col))
            {
                return;
            }

            if (matrix[row, col] != 0)
            {
                return;
            }

            matrix[row, col] = 2;
            count++;
            area.Add(new Tuple<int, int>(row, col));

            FindArea(matrix, row, col - 1, ref count, ref area); // left
            FindArea(matrix, row - 1, col, ref count, ref area); // up
            FindArea(matrix, row, col + 1, ref count, ref area); // right
            FindArea(matrix, row + 1, col, ref count, ref area); // down
        }

        private static void PrintArea(List<Tuple<int, int>> area)
        {
            Console.Write("Found area: ");
            foreach (var cell in area)
            {
                Console.Write("({0},{1}) -> ", cell.Item1, cell.Item2);
            }
            Console.WriteLine("length -> {0} cells", area.Count);
            Console.WriteLine();
        }

        private static bool InRange(int[,] matrix, int row, int col)
        {
            bool rowInRange = row >= 0 && row < matrix.GetLength(0);
            bool colInRange = col >= 0 && col < matrix.GetLength(1);
            return rowInRange && colInRange;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static int[,] GenerateMatrix(int n, int m)
        {
            int[,] matrix = new int[n, m];
            var rand = new Random();
            for (int i = 0; i < percentUnreachableCells * (m * n); i++)
            {
                int randRow = rand.Next(0, n);
                int randCol = rand.Next(0, m);
                matrix[randRow, randCol] = 1;
            }

            return matrix;
        }
    }
}
