namespace _05.Jedi_Meditation
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var result = input
                .GroupBy(x => x[0])
                .ToDictionary(g => g.Key, g => g)
                .OrderBy(x => x.Key == 'm' ? 1 : 
                              x.Key == 'k' ? 2 : 
                                             3);

            Console.WriteLine(string.Join(" ", result.SelectMany(x => x.Value)));
        }
    }
}
