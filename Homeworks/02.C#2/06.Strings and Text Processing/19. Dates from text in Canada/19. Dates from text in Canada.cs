/*•	Write a program that extracts from a given text all dates that match the 
             * format DD.MM.YYYY.
              •	Display them in the standard date format for Canada.*/

using System;
using System.Globalization;

    class DatesFromTextInCanada
    {
        static void Main()
        {
            Console.WriteLine("Enter date in the format: DD.MM.YYYY");
            DateTime input = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(input.ToString(CultureInfo.GetCultureInfo("en- CA")));

        }
    }

