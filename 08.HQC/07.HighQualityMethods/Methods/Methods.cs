namespace Methods
{
    using System;

    public class Methods
    {
        private enum Position
        {
            Horizontal,
            Vertical,
            Other
        }

        static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double tempMultiplication = halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC);
            double area = Math.Sqrt(tempMultiplication);
            return area;
        }

        static string DigitAsText(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid digit!");
            }
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("elemets cannot be null or empty");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        static void PrintAsNumber(object number, string format)
        {
            switch (format)
            {
                case "Accounting": Console.WriteLine("{0:f2}", number);
                    break;
                case "Percent": Console.WriteLine("{0:p0}", number);
                    break;
                case "AlignRight": Console.WriteLine("{0,8}", number);
                    break;
                default: throw new ArgumentException("Invalid format");
            }
        }

        static double CalcDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double horizontalDistanceSquare = (firstPointX - secondPointX) * (firstPointX - secondPointX);
            double verticalDistanceSquare = (firstPointY - secondPointY) * (firstPointY - secondPointY);
            double pointsDistance = Math.Sqrt(horizontalDistanceSquare + verticalDistanceSquare);
            return pointsDistance;
        }

        static Position GetPosition(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            if (firstPointX == secondPointX)
            {
                return Position.Horizontal;
            }
            else if (firstPointY == secondPointY)
            {
                return Position.Vertical;
            }
            else
            {
                return Position.Other;
            }
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            Console.WriteLine(DigitAsText(5));
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "Accounting");
            PrintAsNumber(0.75, "Percent");
            PrintAsNumber(2.30, "AlignRight");

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Position? " + GetPosition(3, -1, 3, 2.5));

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "Sofia");
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 3), "Vidin", "gamer", "high results");
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
