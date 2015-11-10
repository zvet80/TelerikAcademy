namespace _03.BiDictionary
{
    /*3.Implement a class BiDictionary<K1,K2,T> that allows adding triples {key1, key2, value} and fast search by key1, key2 or by both key1 and key2.
        Note: multiple values can be stored for given key.*/

    using System;

    public class Startup
    {
        public static void Main()
        {
            var dict = new BiDictionary<int, int, string>(true);

            dict.Add(1, 2, "Pesho");
            dict.Add(1, 2, "Gosho");
            dict.Add(1, 3, "Mimi");
            dict.Add(1, 3, "Gimi");
            dict.Add(2, 3, "Dimi");
            dict.Remove(1, 3, "Gimi");

            for (int i = 0; i < 1000000; i++)
            {
                dict.Add(i+1, i+2, "Pesho"+i);
            }

            Console.WriteLine("Find by first key");
            dict.FindByFirstKey(1).ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Find by second key");
            dict.FindBySecondKey(4).ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Find by both keys");
            dict.FindByBothKeys(1, 3).ForEach(x => Console.WriteLine(x));
        }
    }
}
