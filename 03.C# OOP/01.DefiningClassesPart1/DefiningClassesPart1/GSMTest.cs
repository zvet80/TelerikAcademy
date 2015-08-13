//Problem 7. GSM test
//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.


namespace DefiningClassesPart1
{
    using System;
    class GSMTest
    {
        public static void Tester()
        {
            GSM gsm1 = new GSM("Lumia", "Nokia");
            GSM gsm2 = new GSM("Galaxy", "Samsung", "Ivo", 506.32,
                                new Battery("qqq", 12.5, 15.3, BatteryType.LiIon),
                                new Display(15.1, 16000));
            GSM gsm3 = new GSM("Asha", "Nokia", "Ina", 201.1);
            GSM gsm4 = new GSM("Exp", "Sony", price: 506.32, display: new Display(17.1));
            GSM[] phones = { gsm1, gsm2, gsm3, gsm4 };

            foreach (var gsm in phones)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4S);
        }

    }
}
