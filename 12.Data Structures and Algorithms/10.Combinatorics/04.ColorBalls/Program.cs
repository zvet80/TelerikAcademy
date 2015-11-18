namespace _04.ColorBalls
{
    using System;
    using System.Linq;
    using System.Numerics;

    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine().Trim();
            int len = input.Length;

            var fact = input
                       .GroupBy(c => c)
                       .Select(gr => gr.Count())
                       .Where(c => c > 1)
                       .ToArray();

            BigInteger denom = 1;
            foreach (var item in fact)
            {
                denom *= Factorial(item);
            }

            BigInteger nom = Factorial(len);
            BigInteger perm = nom / denom;

            Console.WriteLine(perm);
        }

        public static BigInteger Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
