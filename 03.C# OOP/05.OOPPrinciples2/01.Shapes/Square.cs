
namespace _01.Shapes
{
    using System;

    class Square : Rectangle
    {
        public Square(double side)
            : base(side, side)
        {           
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Width);
        }
    }
}
