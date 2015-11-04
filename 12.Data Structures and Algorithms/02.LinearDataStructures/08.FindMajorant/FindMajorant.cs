namespace _08.FindMajorant
{
    /**8*The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
        Write a program to find the majorant of given array (if exists).
        Example:
        {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3*/

    using System;
    using System.Linq;

    class FindMajorant
    {
        static void Main()
        {
            int[] arr = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            FindArrMajorant(arr);
        }

        public static void FindArrMajorant(int[] arr)
        {
            var majorant = arr
                    .GroupBy(x => x)
                    .Where(x => x.Count() > arr.Length / 2)
                    .FirstOrDefault();

            Console.WriteLine("The majorant is {0}", majorant == null ? "non existant" : majorant.Key.ToString());
        }
    }
}
