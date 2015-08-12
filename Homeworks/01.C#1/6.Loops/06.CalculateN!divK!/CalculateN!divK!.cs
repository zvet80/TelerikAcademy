//Problem 6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;

class CalculateN_divK
{
    static void Main()
    {
        Console.WriteLine("Enter integer number n (n < 100): ");            
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer divider k (1 < k < n): ");
            int k = int.Parse(Console.ReadLine());            
            int expr = 0;
            int factN = 1;
            int factK = 1;

            for (int i = 1; i <= n; i++)
            {
                factN = factN * i; 
                
                if (i <= k)
	            {
		            factK = factK * i;
	            }      
            }
        expr = factN / factK;    
        Console.WriteLine(expr);        
    }
}

