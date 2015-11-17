namespace _01.IronMQSender
{
    using System;
    using IronMQ;

    public class Sender
    {
        public static void Main()
        {            
            Client client = new Client("564b5ec04aa0310009000103", "fVegtwvQn3N24EGUwHPQ");
            Queue queue = client.Queue("My chat");

            while (true)
            {
                Console.WriteLine("Enter message:");
                string msgSent = Console.ReadLine();
                queue.Push(msgSent);
                Console.WriteLine("Message sent.");
            }
        }
    }
}
