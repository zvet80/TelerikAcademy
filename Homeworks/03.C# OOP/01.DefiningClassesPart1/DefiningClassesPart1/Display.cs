﻿
namespace DefiningClassesPart1
{
    using System;

    public class Display
    {
        private double? size;
        private int? numberOfColors;

        public Display()
        {
        }
        public Display(double? size = null,
                        int? numberOfColors = null)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
        public double? Size
        {
            get { return this.size; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Size should be > 0");
                }
                else
                {
                    this.size = value;
                }
            }
        }
        public int? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number of colors should be > 0");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }
        public override string ToString()
        {
            return String.Format("Size: {0}, Number of colors: {1}",
                                  this.Size, this.NumberOfColors);
        }
    }
}
