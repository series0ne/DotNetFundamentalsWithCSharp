namespace LinqFilterSample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            IEnumerable<int> numbers = Enumerable.Range(1, 100);
            IEnumerable<int> evenNumbers = numbers
                .Where(number => number % 2 == 0);

            IEnumerable<int> squaredEvenNumbers =
                from number in evenNumbers
                select number * number;

            foreach(int number in squaredEvenNumbers)
            {
                Console.WriteLine(number);
            }

            Console.Read();
        }
    }
}
