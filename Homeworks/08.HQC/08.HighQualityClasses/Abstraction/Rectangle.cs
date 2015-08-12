namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }        
    }
}
