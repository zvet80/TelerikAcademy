//Problem 3. Check for a Play Card
//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 


using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine();
        string[] card = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        
        if (Array.IndexOf(card,s) >=0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

