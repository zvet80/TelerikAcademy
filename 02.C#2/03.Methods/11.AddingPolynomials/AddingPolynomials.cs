//Problem 11. Adding polynomials
//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.
//Example:
//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

using System;

class AddingPolynomials
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients of the firts polynomial, separated by space:");
        int[] polyX = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        Console.WriteLine("Enter the coefficients of the second polynomial, separated by space:");
        int[] polyY = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);

        if (polyX.Length<polyY.Length)
        {
            Console.WriteLine("The sum coefficients are: {0}",string.Join(",",PolynomialsSum(polyX, polyY)));
        }
        else
        {
            Console.WriteLine("The sum coefficients are: {0}", string.Join(",", PolynomialsSum(polyY, polyX)));
        }

    }

    private static int[] PolynomialsSum(int[] polyX, int[] polyY)
    {
        Array.Reverse(polyX);
        Array.Reverse(polyY);
        int[] polyZ = new int[polyY.Length];

        for (int i = 0; i < polyX.Length; i++)
        {
            polyZ[i] = polyX[i] + polyY[i];
        }
        for (int i = polyX.Length; i < polyY.Length; i++)
        {
            polyZ[i] = polyY[i];
        }
        Array.Reverse(polyZ);
        return polyZ;
    }
}

