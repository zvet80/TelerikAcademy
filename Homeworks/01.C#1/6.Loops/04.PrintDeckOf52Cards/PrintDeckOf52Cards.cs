//Problem 4. Print a Deck of 52 Cards
//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        for (int card = 2; card <= 14; card++)
        {
            for (int suit = 1; suit <= 4; suit++)
            {
                switch (card)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10: Console.Write(card); break;
                    case 11: Console.Write("jack"); break;
                    case 12: Console.Write("queen"); break;
                    case 13: Console.Write("king"); break;
                    case 14: Console.Write("ace"); break;
                }
                Console.Write(" of ");
                switch (suit)
                {
                    case 1: Console.Write("clubs"); break;
                    case 2: Console.Write("diamonds"); break;
                    case 3: Console.Write("hearts"); break;
                    case 4: Console.Write("spades"); break;
                }                
                Console.Write(",");
            }
            Console.WriteLine();
        }             
    }
}

