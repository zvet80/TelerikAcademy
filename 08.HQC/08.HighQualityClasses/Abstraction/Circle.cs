namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        public Circle(double radius)
            : base(radius, radius)
        {
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Height;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * base.CalcSurface();
            return surface;
        }
    }
}
