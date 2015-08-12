namespace Matrix
{
    using System;

    public class GameLogic
    {
        private static readonly MatrixCell[] Direction =
        {
            new MatrixCell(1, 1), 
            new MatrixCell(1, 0),
            new MatrixCell(1, -1),
            new MatrixCell(0, -1),
            new MatrixCell(-1, -1),
            new MatrixCell(-1, 0),
            new MatrixCell(-1, 1),
            new MatrixCell(0, 1)
        };

        public static bool CanMove(Matrix matrix, MatrixCell cell)
        {
            if (!matrix.IsInMatrix(cell) ||
                matrix.GetCellValue(cell) != 0)
            {
                return false;
            }

            return true;
        }

        public static MatrixCell ChangeDirection(MatrixCell cellChange)
        {
            int curr = Array.IndexOf(Direction, cellChange);
            int next = (curr + 1) % Direction.Length;
            return Direction[next];
        }

        public static bool IsEmptyNeighbour(Matrix matrix, MatrixCell cell)
        {
            MatrixCell next = new MatrixCell(0, 0);

            for (int i = 0; i < Direction.Length; i++)
            {
                next = cell + Direction[i];

                if (CanMove(matrix, next))
                {
                    if (matrix.GetCellValue(next) == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static void FillPath(Matrix matrix)
        {
            int step = 1;
            MatrixCell position = new MatrixCell(0, 0);
            MatrixCell cellChange = Direction[0];

            while (step <= matrix.Size * matrix.Size)
            {
                while (CanMove(matrix, position))
                {
                    matrix.SetCellValue(position, step);
                    position += cellChange;
                    step++;
                }

                position -= cellChange;

                if (!IsEmptyNeighbour(matrix, position) &&
                    matrix.FindCell(0) != null)
                {
                    position = matrix.FindCell(0);
                    cellChange = Direction[0];
                }
                else
                {
                    cellChange = ChangeDirection(cellChange);
                    position += cellChange;
                }
            }
        }
    }
}
