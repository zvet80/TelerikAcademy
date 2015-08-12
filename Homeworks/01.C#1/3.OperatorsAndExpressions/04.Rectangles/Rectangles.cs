//Problem 4. Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height.


using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please, enter width: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please, enter height: ");
        double y = double.Parse(Console.ReadLine());
        
        double perimeter = 2 * (x + y);
        double area = x * y;
        Console.WriteLine("The perimeter of the rectangle is {0} " +
            "and the area is {1}",perimeter,area);
    }
}

