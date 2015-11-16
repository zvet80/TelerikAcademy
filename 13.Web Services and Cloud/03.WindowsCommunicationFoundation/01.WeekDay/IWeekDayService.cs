namespace _01.WeekDay
{
    using System;
    using System.ServiceModel;

    [ServiceContract]
    public interface IWeekDayService
    {
        [OperationContract]
        string GetWeekDayInBulgarian(DateTime date);
    }
}
