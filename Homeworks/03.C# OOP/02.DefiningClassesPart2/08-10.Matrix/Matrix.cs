using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_10.Matrix
{
    public class Matrix<T> where T : struct, IComparable
    {
        private int row;
        private int col;
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matrix = new T[row, col];
        }
        public int Row
        {
            get { return this.row; }
            set
            {
                if (this.row < 0)
                {
                    throw new ArgumentOutOfRangeException("rows should be > 0");
                }
                this.row = value;
            }
        }
        public int Col
        {
            get { return this.col; }
            set
            {
                if (this.col < 0)
                {
                    throw new ArgumentOutOfRangeException("col should be > 0");
                }
                this.col = value;
            }
        }

        //public T[,] Matrix { get; set; }

        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set
            {
                if (row < 0 || row > this.matrix.GetLength(0)
                    || col < 0 || col > this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                this.matrix[row, col] = value;
            }
        }
        public static Matrix<T> operator + (Matrix<T> mtx1,Matrix<T> mtx2)
        {
            if (mtx1.Row != mtx2.Row || mtx1.Col != mtx2.Col)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            Matrix<T> result = new Matrix<T>(mtx1.Row, mtx1.Col);

            for (int i = 0; i < result.Row; i++)
            {
                for (int j = 0; j < result.Col; j++)
                {
                    result[i, j] = (dynamic)mtx1[i, j] + mtx2[i, j];
                }
            }

            return result;
        }
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Row != matrix2.Row || matrix1.Col != matrix2.Col)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            Matrix<T> result = new Matrix<T>(matrix1.Row, matrix1.Col);

            for (int i = 0; i < result.Row; i++)
            {
                for (int j = 0; j < result.Col; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Col != matrix2.Row)
            {
                throw new ArgumentException("These matrices cannot be multiplied");
            }
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.Row, matrix2.Col);
            T result = (dynamic)0;
            for (int i = 0; i < matrix1.Row; i++)
            {
                for (int j = 0; j < matrix2.Col; j++)
                {
                    for (int k = 0; k < matrix1.Col; k++)
                    {
                        result += (dynamic)matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = result;
                    result = (dynamic)0;
                }
            }
            return resultMatrix;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    result.Append(string.Format("{0}", this.matrix[i, j]));
                }
                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }

        public static bool operator true(Matrix<T> matrix)
        {

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }


    }
}
