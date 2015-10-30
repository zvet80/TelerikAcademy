namespace Task4.Exam3
{
    using System;
    using System.Numerics;

    class ExamTask3
    {
        static void Main()
        {
            const int MaxTransformations = 10;

            BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());
            int numberOfTransformations = 0;

            while (inputNumber >= 10 && numberOfTransformations < MaxTransformations)
            {
                numberOfTransformations++;
                inputNumber /= 10;
                inputNumber = GetProductOfSums(inputNumber);

            }

            if (numberOfTransformations < MaxTransformations)
            {
                Console.WriteLine(numberOfTransformations);
            }
            Console.WriteLine(inputNumber);
        }

        private static BigInteger GetProductOfSums(BigInteger number)
        {
            BigInteger productOfSums = 1;
            int sumOfDigits = 0;

            while (number > 0)
            {
                sumOfDigits = SumDigitsAtEvenPositions(Convert.ToString(number));
                productOfSums *= sumOfDigits;
                number /= 10;
            }
            return productOfSums;
        }

        private static int SumDigitsAtEvenPositions(string number)
        {
            int sum = 0;

            for (int i = 0; i < number.Length; i += 2)
            {
                // Transforms the ASCII Code of the symbol to number
                sum += number[i] - '0';
            }
            return sum;
        }
    }
}
