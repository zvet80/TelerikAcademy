//Problem 3. Min, Max, Sum and Average of N Numbers
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSumAverageOfNNumbers
{    
    static void Main()
    {
        Console.WriteLine("Enter a positive integer:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers, each on a separate line", n);
        int x = int.Parse(Console.ReadLine());
        double avg = 0.0;        
        double sum = 0;        
        int min = x;
        int max = x;
        
        for (int i = 1; i < n; i++)
        {
            x = int.Parse(Console.ReadLine());
            sum += x;
            avg = sum / i;
            
            if (min > x)
            {
                min = x;                
            }
            if (max < x)
            {
               max = x;
            }      
            
        }
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}", min, max, sum, avg);        
    }
}

