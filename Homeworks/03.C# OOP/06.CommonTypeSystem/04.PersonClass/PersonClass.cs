//Problem 4. Person class
//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

namespace _04.PersonClass
{
    using System;

    class PersonClass
    {
        static void Main()
        {
            var person = new Person() { Name = "Ivan", Age = 18 };
            var anotherPerson = new Person() { Name = "Gosho" };
            Console.WriteLine(person.ToString());
            Console.WriteLine(anotherPerson.ToString());
        }
    }

}