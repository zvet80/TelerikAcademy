namespace _02.ColorBunnies
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int[] answers = new int[count];
            for (int i = 0; i < count; i++)
            {
                answers[i] = int.Parse(Console.ReadLine());
            }           

            Console.WriteLine(GetMinCount(answers));
        }

        public static int GetMinCount(int[] answers)
        {
            var sum = 0;
            var dic = answers.GroupBy(x => x);
            foreach (var item in dic)
            {
                if (item.Count() <= item.Key)
                {
                    sum += item.Key + 1;
                }
                else
                {
                    if (item.Count() % (item.Key + 1) != 0)
                    {
                        sum += item.Key + 1;
                    }
                    sum += (item.Count() / (item.Key + 1) * (item.Key + 1));
                }
            }

            return sum;
        }
    }
}
