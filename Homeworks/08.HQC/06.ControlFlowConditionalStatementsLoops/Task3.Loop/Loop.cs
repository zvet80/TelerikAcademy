namespace Task3.Loop
{
    using System;

    class Loop
    {
        static void Main()
        {
            // More code here
        }

        public static void Loop(int[] array, int expectedValue)
        {
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0 && array[i] == expectedValue)
                {
                    isFound = true;
                }

                Console.WriteLine(array[i]);
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
