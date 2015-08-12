namespace Matrix
{
    using System;

    public class MatrixMain
    {
        public static void Main()
        {
            int n = 6;
            Matrix m = new Matrix(n);
            GameLogic.FillPath(m);
            m.PrintMatrix();
        }
    }
}
