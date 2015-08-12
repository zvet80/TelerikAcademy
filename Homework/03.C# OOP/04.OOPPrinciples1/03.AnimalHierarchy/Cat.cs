
namespace _03.AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, sex sex)
            : base(name, age, sex)
        {
        }

        public override void Say()
        {
            Console.WriteLine("The cat say meuw");
        }
    }
}
