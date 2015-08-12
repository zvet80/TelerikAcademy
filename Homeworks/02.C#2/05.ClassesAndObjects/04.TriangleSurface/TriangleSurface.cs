//Problem 4. Triangle surface
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Enter one side of a triangle: ");
        int side = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an altitude of a triangle: ");
        int altitude = int.Parse(Console.ReadLine());
        Console.WriteLine("The area of the triangle is {0:F2}", CalcArea1(side, altitude));
        Console.WriteLine();
        Console.WriteLine("Enter three sides of a triangle (separated by space): ");
        int[] sides = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        Console.WriteLine("The area of the triangle is {0:F2}", CalcArea2(sides[0], sides[1], sides[2]));
        Console.WriteLine();
        Console.WriteLine("Enter one side of a triangle: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second side of a triangle: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the angle bewtween them: ");
        double angle = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of the triangle is {0:F2}", CalcArea3(x, y, angle));
    }

    private static double CalcArea1(int a,int h)
    {       
        double area = (a * h) / 2.00;
        return area;        
    }

    private static double CalcArea2(int a, int b, int c)
    {
        double s = (a + b + c) / 2;
        double area = Math.Sqrt((s*(s - a)*(s - b)*(s - c)));
        return area;
    }

    private static double CalcArea3(int a, int b, double c)
    {
        double val = Math.PI / 180;
        double area = (a * b * Math.Sin(c*val)) / 2;
        return area;
    }
}

