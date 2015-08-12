//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter an integer array (numbers, separated by space):");
        string[] firstArray = Console.ReadLine().Trim().Split(' ');
        Console.WriteLine("Enter a second integer array (numbers, separated by space):");
        string[] secondArray = Console.ReadLine().Trim().Split(' ');
        bool isEqual = true;

        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (int.Parse(firstArray[i]) != int.Parse(secondArray[i]))
                {
                    isEqual = false;                    
                    break;
                }
            }            
        }
        else
        {
            isEqual = false;
        }

        if (isEqual == true)
        {
            Console.WriteLine("The two arrays are equal");
        }
        else
        {
            Console.WriteLine("The two arrays are different");
        }
    }
}

