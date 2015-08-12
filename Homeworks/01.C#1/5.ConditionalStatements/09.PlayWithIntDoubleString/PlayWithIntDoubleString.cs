//Problem 9. Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: \n1 --> int "
            +"\n2 --> double \n3 --> string");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                    Console.Write("Please, enter an integer:");
                    Console.WriteLine(int.Parse(Console.ReadLine()) + 1);
                break;
            case "2":
                    Console.Write("Please, enter a double:");
                    Console.WriteLine(double.Parse(Console.ReadLine()) + 1);
                break;
            case "3":
                    Console.Write("Please, enter a string:");
                    Console.WriteLine(Console.ReadLine() + "*");
                break;
            default: Console.WriteLine("error");
                break;
        }
    }
}

