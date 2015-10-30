namespace Task4.Exam2
{
    using System;

    class ExamTask2
    {
        static void Main()
        {
            const char StopSymbol = '@';

            int module = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            long result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];

                if (current == StopSymbol)
                {
                    break;
                }
                else if (char.IsDigit(current))
                {
                    result *= GetValue(current);
                }
                else if (char.IsLetter(current))
                {
                    result += GetValue(current);
                }
                else
                {
                    result = result % module;
                }
            }
            Console.WriteLine(result);
        }

        private static int GetValue(char symbol)
        {
            int result = 0;

            if (char.IsDigit(symbol))
            {
                // Transforms the ASCII Code of the symbol to number
                result = symbol - '0';
            }
            if (char.IsLetter(symbol))
            {
                // Transforms the ASCII Code of the symbol to the number of the letter in the alphabet
                result = char.ToLower(symbol) - 'a';
            }
            return result;
        }
    }
}
