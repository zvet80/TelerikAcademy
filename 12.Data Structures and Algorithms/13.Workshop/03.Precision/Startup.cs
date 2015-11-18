namespace _03.Precision
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int maxDenom = int.Parse(Console.ReadLine());
            var fraction = Console.ReadLine().Split('.')[1];
            int bestNom = 0;
            int bestDen = 1;
            int precision = 0;

            for (int den = 1; den <= maxDenom; den++)
            {
                int left = 0;
                int right = den;
                //BinarySearch(fraction, left, right, den);
                while (left<right)
                {
                    int mid = (left + right) / 2;
                    if (Compare(fraction,mid, den))
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                int currentPrecision = Precision(fraction, left-1, den);

                if (currentPrecision > precision)
                {
                    bestNom = left-1;
                    bestDen = den;
                    precision = currentPrecision;
                }

                currentPrecision = Precision(fraction, left, den);

                if (currentPrecision > precision)
                {
                    bestNom = left;
                    bestDen = den;
                    precision = currentPrecision;
                }

            }

            Console.WriteLine("{0}/{1}", bestNom, bestDen);
            Console.WriteLine(precision + 1);

        }

        public static bool Compare(string fraction, int a, int b)
        {
            a *= 10;
            int i;
            for (i = 0; i < fraction.Length; i++)
            {
                int digit = a / b;
                if (digit < fraction[i] - '0')
                {
                    return false;
                }
                else if (digit > fraction[i] - '0')
                {
                    return true;
                }

                a = a % b * 10;
            }

            return true;
        }

        public static int Precision(string fraction, int a, int b)
        {
            a *= 10;
            int i;
            for (i = 0; i < fraction.Length; i++)
            {
                int digit = a / b;
                if (digit != fraction[i] - '0')
                {
                    break;
                }

                a = a % b * 10;
            }

            return i;
        }

        public static int BinarySearch(string arr, int left, int right, int value)
        {
            int mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (arr[mid] < value)
                {
                    left = mid + 1;
                    continue;
                }
                else if (arr[mid] > value)
                {
                    right = mid - 1;
                    continue;
                }
                else if (arr[mid] == value)
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
