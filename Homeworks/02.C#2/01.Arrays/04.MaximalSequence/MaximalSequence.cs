//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of elements, separated by comma:");
        string[] sequence = Console.ReadLine().Trim().Split(','); //if elements are not only digits
        string equalElements = "";
        int equal = 0;
        int maxEqual = 0;

        for (int i = 0; i < sequence.Length; i++)
        {            
            if (i > 0 && sequence[i] != sequence[i - 1])
            {
                equal = 1;
            }
            else
            {
                equal++;
            }

            if (maxEqual < equal)
            {
                maxEqual = equal;
                equalElements = sequence[i];
            }
            else if (maxEqual == equal) //ensures to find if 2 or more sequences are of equal max length ex. 1,1,2,3,3
            {                
                equalElements += "," + sequence[i];  //ensures to collect elements of 2 or more chars ex. 11,11
            }
        }
        string[] print = equalElements.Split(',');

        for (int i = 0; i < print.Length; i++)
        {
            for (int j = 0; j < maxEqual; j++)
            {
                if (j == maxEqual - 1)
                {
                    Console.Write(print[i]); 
                }
                else
                {
                    Console.Write(print[i] + ","); 
                }
            }
            Console.WriteLine();            
        }        
    }
}

