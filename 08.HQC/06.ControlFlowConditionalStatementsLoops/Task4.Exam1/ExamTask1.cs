namespace Task4.Exam1
{
    using System;

    class ExamTask1
    {
        static void Main()
        {
            const decimal SheetsPerRealm = 500.00M;

            int numberOfStudents = int.Parse(Console.ReadLine()); //students
            int sheets = int.Parse(Console.ReadLine()); //# paper sheets 500 s per realm
            decimal pricePerRealm = decimal.Parse(Console.ReadLine());

            decimal realms = (numberOfStudents * sheets) / SheetsPerRealm;

            decimal amount = realms * pricePerRealm;

            Console.WriteLine("{0:F2}", amount);

        }
    }
}
