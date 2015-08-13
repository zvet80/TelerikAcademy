namespace Matrix.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MatrixShouldThrowIfInvalidSizeLow()
        {
            var matrix = new Matrix(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MatrixShouldThrowIfInvalidSizeHigh()
        {
            var matrix = new Matrix(101);
        }

        [TestMethod]
        public void FillPathShouldReturnCorrectMatrixOfSize1()
        {
            var matrix = new Matrix(1);
            GameLogic.FillPath(matrix);
            var expected = new int[,] { { 1 } };

            Assert.IsTrue(this.AreEqual(expected, matrix));
        }

        [TestMethod]
        public void FillPathShouldReturnCorrectMatrixOfSize6()
        {
            var matrix = new Matrix(6);
            GameLogic.FillPath(matrix);
            var expected = new int[,] 
            { 
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 30, 3, 26, 30, 22 },
                { 13, 35, 31, 4, 25, 23 },
                { 12, 34, 33, 32, 5, 24 },
                { 11, 10, 9, 8, 7, 6 }
            };

            Assert.IsTrue(this.AreEqual(expected, matrix));
        }

        private bool AreEqual(int[,] expected, Matrix actual)
        {
            if (expected.GetLength(0) != actual.Size ||
                expected.GetLength(1) != actual.Size)
            {
                return false;
            }

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    if (expected[i, j] != actual[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
