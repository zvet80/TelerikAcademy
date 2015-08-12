//Problem 5. Workdays
//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.


using System;
using System.Linq;

class Workdays
{
    static void Main()
    {
        Console.WriteLine("Please enter date in format DD/MM/YYYY:");
        DateTime date = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;

        if (today > date)
        {
            Console.WriteLine("The number of workdays between today and {0:dd/MM/yyyy} is {1}", date, CalcWorkdays(date, today));
        }
        else
        {
            Console.WriteLine("The number of workdays between today and {0:dd/MM/yyyy} is {1}", date, CalcWorkdays(today, date));
        }
    }

    private static int CalcWorkdays(DateTime from, DateTime to)
    {
        int businessDays = 0;

        for (DateTime i = from.AddDays(1); i <= to; i = i.AddDays(1))
        {
            if (i.DayOfWeek != DayOfWeek.Saturday
                && i.DayOfWeek != DayOfWeek.Sunday
                && !IsHoliday(i))
                businessDays++;
        }

        return businessDays;
    }
    private static bool IsHoliday(DateTime date)
    {
        DateTime[] holidays = new DateTime[] 
        { new DateTime(2015,01,01),
            new DateTime(2015,03,02),
            new DateTime(2015,03,03),
            new DateTime(2015,04,10),
            new DateTime(2015,04,11),
            new DateTime(2015,04,12),
            new DateTime(2015,04,13),
            new DateTime(2015,05,01),
            new DateTime(2015,05,06),
            new DateTime(2015,09,21),
            new DateTime(2015,09,22),
            new DateTime(2015,09,21),
            new DateTime(2015,09,21),
            new DateTime(2015,12,24),
            new DateTime(2015,12,25),
            new DateTime(2015,12,26),
            new DateTime(2015,12,31)};

        return holidays.Contains(date);
    }
}


