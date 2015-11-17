namespace _02.PubNub
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;
    using PubNubMessaging.Core;

    public class PubnubExample
    {
        private const string PublishKey = "pub-c-d4910936-fee3-4584-8642-dcbc87c29564";
        private const string SubscribeKey = "sub-c-47cf76c2-8d59-11e5-a2e7-0619f8945a4f";
        static Action<object> userCallback = new Action<object>((msg)=>Console.Write(""));
        static Action<object> errorCallback = new Action<object>((err) => Console.Write(""));

        static void Main()
        {
            // Start the HTML5 Pubnub client
            Process.Start("..\\..\\Receiver.html");

            Thread.Sleep(2000);

            Pubnub pubnub = new Pubnub(PublishKey, SubscribeKey);
            string channel = "chat";

            // Publish a sample message to Pubnub
            pubnub.Publish(
                channel,
                "Hello Pubnub!",
                userCallback,
                errorCallback
                );

            // Subscribe for receiving messages (in a background task to avoid blocking)
            Task t = new Task(
                () =>
                pubnub.Subscribe(
                    channel,
                    delegate (string message)
                    {
                        Console.WriteLine("Received Message -> '" + message + "'");
                    },
                    userCallback,
                    errorCallback
                )
            );
            t.Start();

            // Read messages from the console and publish them to Pubnub
            while (true)
            {
                Console.WriteLine("Enter a message: ");
                string messageToSend = Console.ReadLine();
                pubnub.Publish(
                    channel,
                    messageToSend,
                    userCallback,
                    errorCallback);
                Console.WriteLine("Message {0} sent.", messageToSend);
                Thread.Sleep(1000);
            }
        }
    }
}