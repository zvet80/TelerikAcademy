namespace Task1.ClassSize
{
    using System;

    public class Size
    {
        private double width, height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Size GetRotatedSize(Size figureToRotate, double angleOfRotation)
        {
            double cos = Math.Abs(Math.Cos(angleOfRotation));
            double sin = Math.Abs(Math.Sin(angleOfRotation));
            double rotatedWidth = cos * figureToRotate.Width + sin * figureToRotate.Height;
            double rotatedHeight = sin * figureToRotate.Width + cos * figureToRotate.Height;
            
            Size rotatedSize = new Size(rotatedWidth, rotatedHeight);
            
            return rotatedSize;
        }
    }
}
