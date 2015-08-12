//Problem 13. Solve tasks
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Choose a task 1,2,3:");
        Console.WriteLine("1.Reverses the digits of a number");
        Console.WriteLine("2.Calculates the average of a sequence of integers");
        Console.WriteLine("3.Solves a linear equation a * x + b = 0");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 1: ReverseDigits(); break;
            case 2: AverageInt(); break;
            case 3: SolveEquation(); break;
            default: Console.WriteLine("Invalid operation");
                break;
        }
    }

    private static void SolveEquation()
    {
        Console.WriteLine("Enter a non-zero coefficient a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b:");
        double b = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("The equation a * x + b = 0 has no solution");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("The solution of the equation a * x + b = 0 is {0:F2}", x);
        }
    }

    private static void AverageInt()
    {
        Console.WriteLine("Enter integers, separated by space:");
        string x = Console.ReadLine();

        if (x.Length==0)
        {
            Console.WriteLine("You should enter at least one number");
        }
        else
        {
            double[] arr = Array.ConvertAll(x.Trim().Split(' '), double.Parse);
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double avg = sum / arr.Length;
            Console.WriteLine("The average of the numbers is: {0:F2}", avg);
        }
    }

    private static void ReverseDigits()
    {
        Console.WriteLine("Enter a positive decimal number: ");
        decimal x = decimal.Parse(Console.ReadLine());

        char[] y = x.ToString().ToCharArray();
        Array.Reverse(y);
        Convert.ToDecimal(new string(y));
        Console.WriteLine(y);
    }
}

