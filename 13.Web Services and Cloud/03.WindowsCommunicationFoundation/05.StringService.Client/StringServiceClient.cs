namespace _05.StringService.Client
{
    using System;

    //README:You should have StringServiceHost from previous task still running to get the result

    public class StringServiceClient
    {
        public static void Main()
        {
            StringOccurrenceServiceClient client = new StringOccurrenceServiceClient();

            string str = "c";
            string txt = "Create a console client";
            int result = client.CountStringOccurrences(str, txt);
            
            Console.WriteLine("The string \"{0}\" occurs {1} times in\n\"{2}\" ", str, result, txt);
        }
    }
}
