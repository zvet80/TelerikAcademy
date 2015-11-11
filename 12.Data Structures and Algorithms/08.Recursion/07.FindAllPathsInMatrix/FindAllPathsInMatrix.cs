namespace _07.FindAllPathsInMatrix
{
    /*7.We are given a matrix of passable and non-passable cells.
      Write a recursive program for finding all paths between two cells in the matrix.*/

    using System;
    using System.Collections.Generic;

    public class FindAllPathsInMatrix
    {
        private static char[,] matrix =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'}
        };

        private static List<Tuple<int, int>> path = new List<Tuple<int, int>>();

        public static void Main()
        {
            FindPathToExit(0, 0);
        }

        private static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < matrix.GetLength(0);
            bool colInRange = col >= 0 && col < matrix.GetLength(1);
            return rowInRange && colInRange;
        }

        private static void FindPathToExit(int row, int col)
        {
            if (!InRange(row, col))
            {
                return;
            }

            if (matrix[row, col] == 'e')
            {
                PrintPath(row, col);
            }

            if (matrix[row, col] != ' ')
            {
                return;
            }

            matrix[row, col] = 'v';
            path.Add(new Tuple<int, int>(row, col));

            FindPathToExit(row, col - 1); // left
            FindPathToExit(row - 1, col); // up
            FindPathToExit(row, col + 1); // right
            FindPathToExit(row + 1, col); // down

            matrix[row, col] = ' ';
            path.RemoveAt(path.Count - 1);
        }

        private static void PrintPath(int finalRow, int finalCol)
        {
            Console.Write("Found path: ");
            Console.Write(string.Join("->", path));
            Console.WriteLine("->({0},{1})", finalRow, finalCol);
            Console.WriteLine();
        }
    }
}
