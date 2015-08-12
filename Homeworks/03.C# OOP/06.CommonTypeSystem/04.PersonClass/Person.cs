
namespace _04.PersonClass
{
    using System;

    public class Person
    {
        public Person()
        {
        }

        public string Name { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            if (this.Age == null)
            {
            return string.Format("Name: {0}\nAge: {1}", this.Name, "not specified");
            }
            return string.Format("Name: {0}\nAge: {1}", this.Name, this.Age);
        }
    }
}
