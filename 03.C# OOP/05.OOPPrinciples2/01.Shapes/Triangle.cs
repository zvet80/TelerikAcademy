﻿
namespace _01.Shapes
{
    using System;

    class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }
    }
}
