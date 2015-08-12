//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Please, enter a point with coordinates x,y: ");
        string inputs = Console.ReadLine();
        double x = Convert.ToDouble(inputs.Split(',')[0]);
        double y = Convert.ToDouble(inputs.Split(',')[1]);
        if ((x * x + y * y) <= 4)
            Console.WriteLine("The point ({0},{1}) is inside a circle K({{0,0}}, 2)", x, y);
        else
            Console.WriteLine("The point ({0},{1}) is outside a circle K({{0,0}}, 2)", x, y);

        Console.ReadLine();        
    }
}

