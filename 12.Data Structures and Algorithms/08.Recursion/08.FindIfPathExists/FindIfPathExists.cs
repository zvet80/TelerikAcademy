namespace _08.FindIfPathExists
{
    /*8.Modify the above program to check whether a path exists between two cells without finding all possible paths.
       Test it over an empty 100 x 100 matrix.*/

    using System;

    public class FindIfPathExists
    {
        private static char[,] matrix =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'}
        };

        public static void Main()
        {
            //FindIfPathExists(matrix, 0, 0);

            char[,] matrix2 = new char[100, 100];
            matrix2[99, 99] = 'e';
            FindAtLeastOnePath(matrix2, 0, 0);
        }

        private static bool InRange(char[,] matrix, int row, int col)
        {
            bool rowInRange = row >= 0 && row < matrix.GetLength(0);
            bool colInRange = col >= 0 && col < matrix.GetLength(1);
            return rowInRange && colInRange;
        }

        private static void FindAtLeastOnePath(char[,] matrix, int row, int col)
        {
            if (!InRange(matrix, row, col))
            {
                return;
            }

            if (matrix[row, col] == 'e')
            {
                Console.WriteLine("Path exists!");
                Environment.Exit(0);
            }

            if (matrix[row, col] != '\0' && matrix[row, col] != ' ')
            {
                return;
            }

            matrix[row, col] = 'v';

            FindAtLeastOnePath(matrix, row, col - 1); // left
            FindAtLeastOnePath(matrix, row - 1, col); // up
            FindAtLeastOnePath(matrix, row, col + 1); // right
            FindAtLeastOnePath(matrix, row + 1, col); // down
        }
    }
}
