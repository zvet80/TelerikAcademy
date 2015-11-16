namespace _01.WeekDay
{
    using System;
    using System.Globalization;

    public class WeekDayService : IWeekDayService
    {
        public string GetWeekDayInBulgarian(DateTime date)
        {
            var culture = new CultureInfo("bg-BG");
            return culture.DateTimeFormat.GetDayName(date.DayOfWeek);
        }
    }
}
