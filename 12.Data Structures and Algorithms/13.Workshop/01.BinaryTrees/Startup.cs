namespace _01.BinaryTrees
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine().Trim();
            int len = input.Length;

            if (len < 1 || len > 20)
            {
                throw new Exception("error");
            }

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

            long nom = Factorial(len);
            BigInteger perm = nom / denom;
            BigInteger result = catalan(len) * perm;

            Console.WriteLine(result);
        }

        public static long Factorial(int n)
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

        public static long catalan(int n)
        {
            if (n == 1)
            {
                return 1; //since c(1)=1 is the base case
            }
            else
            {
                n = n - 1;
                return ((catalan(n) * (2 * n + 2) * (2 * n + 1)) / ((n + 1) * (n + 2)));
            }
        }
    }
}
