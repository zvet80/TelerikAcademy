//Problem 12. Subtracting polynomials
//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;

class SubtractingPolynomials
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients of the first polynomial, separated by space:");
        int[] polyX = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        Console.WriteLine("Enter the coefficients of the second polynomial, separated by space:");
        int[] polyY = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        Console.WriteLine("Enter operation 1,2,3 (sum 1, subtract 2, multiply 3): ");
        int op = int.Parse(Console.ReadLine());
                
        Console.WriteLine("The result coefficients are: {0}", string.Join(",", PolynomialsOperation(polyX, polyY, op)));
    }

    private static List<int> PolynomialsOperation(int[] polyX, int[] polyY, int op)
    {
        Array.Reverse(polyX);
        Array.Reverse(polyY);
        List<int> polyZ = new List<int>();
        int biggerLength = Math.Max(polyX.Length, polyY.Length);

        if (op == 1)
        {
            for (int i = 0; i < biggerLength; i++)
            {
                if (i < polyX.Length && i < polyY.Length)
                {
                    polyZ.Add(polyX[i] + polyY[i]);
                }
                else if (polyX.Length > polyY.Length)
                {
                    polyZ.Add(polyX[i]);
                }
                else
                {
                    polyZ.Add(polyY[i]);
                }
            }
        }
        if (op == 2)
        {
            for (int i = 0; i < biggerLength; i++)
            {
                if (i < polyX.Length && i < polyY.Length)
                {
                    polyZ.Add(polyX[i] - polyY[i]);
                }
                else if (polyX.Length > polyY.Length)
                {
                    polyZ.Add(polyX[i]);
                }
                else
                {
                    polyZ.Add(-polyY[i]);
                }
            }            
        }
        if (op == 3)
        {
            for (int i = 0; i < polyX.Length; i++)
            {
                for (int j = 0; j < polyY.Length; j++)
                {
                    polyZ.Add(polyX[i] * polyY[j]);
                }
            }
        }

        polyZ.Reverse();
        return polyZ;
    }
}

