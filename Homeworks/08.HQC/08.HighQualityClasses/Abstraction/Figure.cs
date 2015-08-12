namespace Abstraction
{
    using System;

    public abstract class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format("{0}'s {1} must be positive", this.GetType().Name, this.GetType().GetConstructors()[0].GetParameters()[0].Name));
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format("{0}'s {1} must be positive", this.GetType().Name, this.GetType().GetConstructors()[0].GetParameters()[1].Name));
                }

                this.height = value;
            }
        }

        public abstract double CalcPerimeter();

        public virtual double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
