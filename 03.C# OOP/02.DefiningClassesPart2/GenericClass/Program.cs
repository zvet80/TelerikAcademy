using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main()
        {
            GenericList<int> numbers = new GenericList<int>();
            numbers.Add(5);
            numbers.Insert(9, 0);
            numbers.Add(8);
            Console.WriteLine(numbers);
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Access(0));
            numbers.Remove(1);
            Console.WriteLine(numbers);
            numbers.AutoGrow();
            Console.WriteLine(numbers);
            Console.WriteLine(numbers.IndexOf(8));
            numbers.Clear();
            Console.WriteLine(numbers);
        }
    }
}
