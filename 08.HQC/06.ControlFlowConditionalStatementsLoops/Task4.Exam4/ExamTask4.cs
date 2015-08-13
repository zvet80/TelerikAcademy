namespace Task4.Exam4
{
    using System;

    class ExamTask4
    {
        private const char Colon = ':';
        private const char Space = ' ';
        private const char LetterX = 'X';
        private const char Slash = '/';

        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            //first line
            Draw(Space, size - 1);
            Draw(Colon, size);
            Console.WriteLine();

            //draw upper side
            for (int i = 1; i <= size - 2; i++)
            {
                Draw(Space, size - i - 1);
                Draw(Colon, 1);
                Draw(Slash, size - 2);
                Draw(Colon, 1);
                Draw(LetterX, i - 1);
                Draw(Colon, 1);
                Console.WriteLine();
            }

            //draw upper edge
            Draw(Colon, size);
            Draw(LetterX, size - 2);
            Draw(Colon, 1);
            Console.WriteLine();

            //draw face
            for (int i = 1; i <= size - 2; i++)
            {
                Draw(Colon, 1);
                Draw(Space, size - 2);
                Draw(Colon, 1);
                Draw(LetterX, size - i - 2);
                Draw(Colon, 1);
                Console.WriteLine();
            }

            //draw bottom edge
            Draw(Colon, size);
            Console.WriteLine();
        }

        private static void Draw(char symbol, int repetitions)
        {
            Console.Write(new string(symbol, repetitions));
        }
    }
}
