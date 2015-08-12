//Problem 10. Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("Please, enter a point with coordinates x,y: ");
        string inputs = Console.ReadLine();
        double x = Convert.ToDouble(inputs.Split(',')[0]);
        double y = Convert.ToDouble(inputs.Split(',')[1]);
        bool insideCircle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= 1.5 * 1.5);
        bool insideRectangle = ((x >= -1) && (x <= 5)) && ((y >= -1) && (y <= 1));
        bool result = (insideCircle == true) && (insideRectangle == false);
        Console.WriteLine("inside K & outside of R {0} ",result);
        Console.WriteLine();
    }
}

