namespace _02.WeekDayService.Console
{
    using System;    
    using System.Text;
    using WeekDayService;

    public class Client
    {
        public static void Main()
        {
            WeekDayServiceClient weekdayClient = new WeekDayServiceClient();
            string result = weekdayClient.GetWeekDayInBulgarian(DateTime.Now);
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Днес е: " + result);
        }
    }
}
