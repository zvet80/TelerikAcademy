namespace _03.StringService.Library
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IStringOccurrenceService
    {
        [OperationContract]
        int CountStringOccurrences(string word, string text);
    }
}
