
namespace _03.AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, sex sex)
            : base(name, age, sex)
        {
        }

        public override void Say()
        {
            Console.WriteLine("The dog say bau");
        }
    }
}
