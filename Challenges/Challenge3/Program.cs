namespace Challenge3
{
    using System;
    using System.Linq;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Enumerable
                .Range(1, 100)
                .Where(i => i % 2 != 0)
                .OrderBy(i => i)
                .ToArray();

            foreach (Sum sum in Sum.GetDistinctSums(numbers))
            {
                Console.WriteLine(sum);
            }

            Console.Read();
        }
    }
}
