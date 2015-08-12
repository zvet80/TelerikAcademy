//Problem 3. Animal hierarchy
//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace _03.AnimalHierarchy
{
    using System;
    using System.Linq;

    public class AnimalHierarchy
    {
        static void Main()
        {
            Animal[] animals = 
            {
                new Dog("Sharo",5, sex.Male),
                new Dog("Lassy",4, sex.Female),
                new Cat("Mimi",2,sex.Female),
                new Tomcat("Gosho",1),
                new Kitten("Sara",3),
                new Frog("Zara",2, sex.Female),
                new Frog("Zoro",1,sex.Male)
            };

            var avgGroup = animals
                .GroupBy(x => x.GetType())
                .Select(g => new { Group = g.Key.Name, AvgAge = g.Average(a => a.Age) });

            foreach (var g in avgGroup)
            {
                Console.WriteLine("{0}s are on average {1} years old", g.Group, g.AvgAge);

            }
        }
    }
}

