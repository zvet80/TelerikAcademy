namespace _01.BinaryPasswords
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    count++;
                }
            }

            long perm = (long)Math.Pow(2, count);
            Console.WriteLine(perm);
        }
    }
}
