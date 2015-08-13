//•	Write a program that reads two dates in the format:
//  day.month.year and calculates the number of days between them.

using System;

class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter start date in the format: day.month.year ");
        DateTime start = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter end date in the format: day.month.year ");
        DateTime end = DateTime.Parse(Console.ReadLine());
        TimeSpan diff = end-start;
        Console.WriteLine(Math.Abs(diff.Days));
    }
}

