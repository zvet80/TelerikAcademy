
namespace _03.AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, sex sex)
            : base(name, age, sex)
        {
        }

        public override void Say()
        {
            Console.WriteLine("The frog say quaq");
        }

    }
}
