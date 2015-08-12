namespace Matrix
{
    using System;

    public class MatrixCell
    {
        public MatrixCell(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public static MatrixCell operator +(MatrixCell cell1, MatrixCell cell2)
        {
            return new MatrixCell(cell1.Row + cell2.Row, cell1.Col + cell2.Col);
        }

        public static MatrixCell operator -(MatrixCell cell1, MatrixCell cell2)
        {
            return new MatrixCell(cell1.Row - cell2.Row, cell1.Col - cell2.Col);
        }
    }
}
