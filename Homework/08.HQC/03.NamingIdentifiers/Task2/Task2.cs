namespace Task2
{
    using System;

    public class People
    {
        enum Gender { male, female };

        public class Person
        {
            public Gender Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void MakePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "John";
                newPerson.Gender = Gender.male;
            }
            else
            {
                newPerson.Name = "Ann";
                newPerson.Gender = Gender.female;
            }
        }
    }
}
