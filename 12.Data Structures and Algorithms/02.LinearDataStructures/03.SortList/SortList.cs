namespace _03.SortList
{
    /*3.Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.*/

    using System;
    using System.Collections.Generic;

    public class SortList
    {
        public static void Main()
        {
            Console.WriteLine("Enter integer numbers:");

            List<int> sequence = new List<int>();
            string input = Console.ReadLine();
            int number = 0;

            while (input != string.Empty)
            {
                bool isIntNumber = int.TryParse(input, out number);

                if (isIntNumber)
                {
                    sequence.Add(number);
                }
                else
                {
                    Console.WriteLine("Enter an integer number:");
                }

                input = Console.ReadLine();
            }

            sequence.Sort();
            Console.WriteLine("The sorted numbers are:");
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
