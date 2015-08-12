namespace Matrix
{
    using System;

    public class Matrix
    {
        private const int MinSize = 1;
        private const int MaxSize = 100;
        private int size;
        private int[,] matrix;

        public Matrix(int size)
        {
            this.Size = size;
            this.matrix = new int[this.Size, this.Size];
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value < MinSize || value > MaxSize)
                {
                    throw new ArgumentException(string.Format("Matrix size should be in the range [{0}, {1}]", MinSize, MaxSize));
                }

                this.size = value;
            }
        }

        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        public bool IsInMatrix(MatrixCell cell)
        {
            bool rowIsInRange = cell.Row >= 0 && cell.Row < this.Size;
            bool colIsInRange = cell.Col >= 0 && cell.Col < this.Size;

            return rowIsInRange && colIsInRange;
        }

        public int GetCellValue(MatrixCell cell)
        {
            int result = 0;

            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    if (cell.Row == i && cell.Col == j)
                    {
                        result = this.matrix[i, j];
                    }
                }
            }

            return result;
        }

        public void SetCellValue(MatrixCell cell, int value)
        {
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    if (cell.Row == i && cell.Col == j)
                    {
                        this.matrix[i, j] = value;
                    }
                }
            }
        }

        public MatrixCell FindCell(int searchValue)
        {
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    if (this.matrix[i, j] == searchValue)
                    {
                        return new MatrixCell(i, j);
                    }
                }
            }

            return null;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    Console.Write("{0,3}", this.matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
