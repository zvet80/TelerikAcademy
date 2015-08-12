//•	Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter expression:");
        string s = Console.ReadLine();
        int countOpen = 0;
        int countClose = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                countOpen++;  
            }
            if (s[i] == ')')
            {
                countClose++;
            }
        }
        if (countOpen==countClose)
        {
            Console.WriteLine("The brackets are put correctly");
        }
        else
        {
            Console.WriteLine("The brackets are not put correctly");   
        }
    }
}

