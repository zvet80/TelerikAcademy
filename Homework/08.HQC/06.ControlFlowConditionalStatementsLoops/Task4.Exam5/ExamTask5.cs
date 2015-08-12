namespace Task4.Exam5
{
    using System;

    class ExamTask5
    {
        public const int NeededBits = 30;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int inputNumber;
            string bitsOfInput;
            string bits = "";

            for (int i = 0; i < n; i++)
            {
                inputNumber = int.Parse(Console.ReadLine());
                bitsOfInput = Convert.ToString(inputNumber, 2).PadLeft(NeededBits, '0');
                bitsOfInput = bitsOfInput.Substring((bitsOfInput.Length - NeededBits), NeededBits);
                bits += bitsOfInput;
            }

            Console.WriteLine(CountLongestSequence(bits, '0'));
            Console.WriteLine(CountLongestSequence(bits, '1'));
        }

        public static int CountLongestSequence(string input, char symbol)
        {
            int max = 0;
            int maxTemp = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ((i > 0) && (input[i] != input[i - 1]))
                {
                    maxTemp = 0;
                }

                if (input[i] == symbol)
                {
                    maxTemp++;
                }

                if (max < maxTemp)
                {
                    max = maxTemp;
                }
            }

            return max;
        }
    }
}

