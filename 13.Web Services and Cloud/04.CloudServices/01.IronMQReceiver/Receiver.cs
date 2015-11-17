namespace _01.IronMQReceiver
{
    using System;
    using System.Threading;
    using IronMQ;
    using IronMQ.Data;

    public class Receiver
    {
        public static void Main()
        {
            Client client = new Client("564b5ec04aa0310009000103", "fVegtwvQn3N24EGUwHPQ");
            Queue queue = client.Queue("My chat");
            Console.WriteLine("Listening for new messages from IronMQ server:");

            while (true)
            {
                Message msgReceived = queue.Get();
                if (msgReceived != null)
                {
                    Console.WriteLine(msgReceived.Body);
                    queue.DeleteMessage(msgReceived);
                }
                Thread.Sleep(100);
            }
        }
    }
}
