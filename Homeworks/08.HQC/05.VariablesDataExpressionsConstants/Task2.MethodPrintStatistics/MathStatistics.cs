namespace Task2.MethodPrintStatistics
{
    using System;

    public class MathStatistics
    {
        public void PrintStatistics(double[] arr)
        {
            Console.WriteLine("the min value in the array is {0}", this.GetMin(arr));
            Console.WriteLine("the max value in the array is {0}", this.GetMax(arr));
            Console.WriteLine("the average value in the array is {0}", this.GetAvg(arr));
        }

        public double GetMin(double[] arr)
        {
            double min = double.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public double GetMax(double[] arr)
        {
            double max = double.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public double GetAvg(double[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            double avg = sum / arr.Length;
            return avg;
        }
    }
}
