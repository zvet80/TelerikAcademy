namespace _04.StringService.Console
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using _03.StringService.Library;

    //README: Build solution, then open solution folder and run .exe as Administrator.

    public class StringServiceHost
    {
        public static void Main()
        {
            Uri serviceAddress = new Uri("http://localhost:1234/StringService");
            ServiceHost selfHost = new ServiceHost(typeof(StringOccurrenceService), serviceAddress);

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);

            using (selfHost)
            {
                selfHost.Open();
                System.Console.WriteLine("The service is started at endpoint " + serviceAddress);

                System.Console.WriteLine("Press [Enter] to exit.");
                System.Console.ReadLine();
            }
        }
    }
}
