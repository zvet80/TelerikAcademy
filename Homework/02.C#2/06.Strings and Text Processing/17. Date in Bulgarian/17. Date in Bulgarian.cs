/*•	Write a program that reads a date and time given in the format:
         * day.month.year hour:minute:second and prints the date and time 
         * after 6 hours and 30 minutes (in the same format) along with the 
         * day of week in Bulgarian.*/

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Enter date and time in the format: day.month.year hour:minute:second");
        DateTime input = DateTime.Parse(Console.ReadLine());
        Console.OutputEncoding = Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");
        input = input.AddDays(6.5);
        Console.WriteLine("след 6:30 часа: {0} {1}",DateTimeFormatInfo.CurrentInfo.GetDayName(input.DayOfWeek),input);        
    }
}
