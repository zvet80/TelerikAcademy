//Problem 1. Student class
//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//Problem 2. IClonable
//Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
//Problem 3. IComparable
//Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).


namespace _01.StudentClass
{
    using System;

    class StudentClass
    {
        static void Main()
        {
            var st1 = new Student() { FirstName = "Mimi", LastName = "Ivanova", SSN = 589762, Specialty = Specialty.Mathematics };
            var st2 = new Student() { FirstName = "Mimito", LastName = "Ivanova" };
            var st3 = new Student() { FirstName = "Mimi", LastName = "Ivanova", SSN = 125639, Specialty = Specialty.Informatics };
            Console.WriteLine(st1.Equals(st2));
            Console.WriteLine(st1.Equals(st3));
            Console.WriteLine(st1 == st2);
            Console.WriteLine(st1.ToString());
            Console.WriteLine(st3.GetHashCode());
            Console.WriteLine(st1.Clone().ToString());
            Console.WriteLine(st1.CompareTo(st3));
        }
    }

}