//Problem 1. Shapes
//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
//Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.

namespace _01.Shapes
{
    using System;

    class Shapes
    {
        static void Main()
        {
            Shape[] shapes = 
            {
                new Triangle(5.2,8),
                new Rectangle(8.3,5),
                new Square(5)
            };

            foreach (var s in shapes)
            {
                Console.WriteLine("The area of the {0} is {1} ",
                    s.GetType().Name, s.CalculateSurface());
            }
        }
    }
}

