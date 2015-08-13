//Problem 2. Students and workers
//Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.


namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsAndWorkers
    {
        static void Main()
        {
            var listOfStudents = new List<Student>
            {
                new Student("Ivan","Angelov", 6),
                new Student("Petar", "Ivanov", 4),
                new Student("Iskren","Petrov",5),
                new Student("Hristo","Dimitrov", 3),
                new Student("Iva", "Angelova", 2),
                new Student("Petar", "Dimitrov", 5),
                new Student("Iskra","Petrova", 6),
                new Student("Hristina","Ivanova", 2),
                new Student("Ivan","Ivanov", 3),
                new Student("Pesho","Peshov", 2)
            };
            var queryS =
                from s in listOfStudents
                orderby s.Grade
                select s;
            foreach (var s in queryS)
            {
                Console.WriteLine(s.ToString());
            }

            var listOfWorkers = new List<Worker>            
            {
                new Worker("Angel","Angelov", 200.5, 5),
                new Worker("Petar", "Petrov", 100.2,4),
                new Worker("Iskren","Marinov",520.0,3),
                new Worker("Hristo","Ivanov", 410,3),
                new Worker("Iva", "Petrova", 333,2),
                new Worker("Dimitar", "Dimitrov", 265.2,5.2),
                new Worker("Maria","Petrova", 125.6,6),
                new Worker("Anna","Ivanova", 250,6.3),
                new Worker("Ivan","Dimitrov", 380,4.5),
                new Worker("Pesho","Ivanov", 200,5)
            };
            var queryW = listOfWorkers
                          .OrderByDescending(w => w.MoneyPerHour())
                          .Select(w => w);

            foreach (var w in queryW)
            {
                Console.WriteLine(w.ToString() + "," + w.MoneyPerHour());
            }

            var mergedList = new List<Human>();
            mergedList.AddRange(listOfStudents);
            mergedList.AddRange(listOfWorkers);
            var sorted = mergedList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            Console.WriteLine("Sorted merged list:");
            foreach (var p in sorted)
            {
                Console.WriteLine(p.FirstName + " " + p.LastName);
            }


        }
    }
}
