
namespace _03.AnimalHierarchy
{
    using System;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private sex sex;

        public Animal(string name, int age, sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public sex Sex { get; set; }

        public abstract void Say();
    }
}
