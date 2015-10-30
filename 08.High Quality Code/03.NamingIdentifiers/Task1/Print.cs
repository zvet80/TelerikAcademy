namespace Task1
{
    using System;

    public class Print
    {
        const int MaxCount = 6;

        public class PrintBool
        {
            public void Print(bool input)
            {
                string inputAsString = input.ToString();
                Console.WriteLine(inputAsString);
            }
        }
    }
}


