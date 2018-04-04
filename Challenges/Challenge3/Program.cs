namespace Challenge3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
                .Where(i => i % 2 != 0)
                .OrderBy(i => i)
                .ToArray();

            HashSet<PairAndSum> pairs = new HashSet<PairAndSum>();

            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    pairs.Add(new PairAndSum(numbers[i], numbers[j]));
                }
            }

            foreach(PairAndSum pair in pairs)
            {
                Console.WriteLine(pair);
            }

            Console.Read();
        }
    }
}
