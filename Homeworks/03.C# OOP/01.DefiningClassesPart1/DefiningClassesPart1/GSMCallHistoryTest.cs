//Problem 12. Call history test
//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.

using System;
using System.Collections.Generic;

namespace DefiningClassesPart1
{
    public class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            const decimal pricePerMinute = 0.37M;

            GSM myGSM = new GSM("123", "test");
            Call call1 = new Call(DateTime.Parse("21.02.2015 15:20:23"), 632, "0889235363");
            Call call2 = new Call(DateTime.Parse("22.02.2015 01:10:23"), 254, "0887775363");
            Call call3 = new Call(DateTime.Parse("23.02.2015 18:20:23"), 954, "0878787800");

            myGSM.AddCalls(call1);
            myGSM.AddCalls(call2);
            myGSM.AddCalls(call3);

            for (int i = 0; i < myGSM.CallHistory.Count; i++)
            {
                Console.WriteLine(myGSM.CallHistory[i]);
            }

            Console.WriteLine("Total price of the calls in the history = {0:F2}",
                               myGSM.PriceOfCalls(pricePerMinute));

            Call maxCall = new Call();
            for (int i = 0; i < myGSM.CallHistory.Count; i++)
            {
                if (myGSM.CallHistory[i].Duration > maxCall.Duration)
                {
                    maxCall = myGSM.CallHistory[i];
                }
            }
            myGSM.DeleteCalls(maxCall);
            Console.WriteLine("Total price of the calls w/o max call = {0:F2}",
                               myGSM.PriceOfCalls(pricePerMinute));

            myGSM.ClearCallHistory();

            Console.WriteLine("Number of calls after history clear: {0}", myGSM.CallHistory.Count);
        }
    }

}

