namespace _01.SumOfSequence
{
    /* 1.Write a program that reads from the console a sequence of positive integer numbers.
    The sequence ends when empty line is entered.
    Calculate and print the sum and average of the elements of the sequence.
    Keep the sequence in List<int>.*/

    using System;
    using System.Collections.Generic;

    public class SumOfSequence
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive integer number:");

            List<int> sequence = new List<int>();
            string input = Console.ReadLine();
            int number = 0;
            int sum = 0;

            while (input != string.Empty)
            {
                bool isIntNumber = int.TryParse(input, out number);
                bool isPositive = number > 0;

                if (isIntNumber && isPositive)
                {
                    sequence.Add(number);
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Enter a positive integer number:");
                }

                input = Console.ReadLine();
            }

            double avg = (double)sum / (sequence.Count == 0 ? 1 : sequence.Count);
            Console.WriteLine("The sum of the numbers is: {0}", sum);
            Console.WriteLine("The average of the numbers is: {0:F2}", avg);
        }
    }
}
