namespace LinqSample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            IEnumerable<int> numbers = Enumerable.Range(1, 1000);

            IEnumerable<string> names = new string[]
            {
                "Harry Potter",
                "Ronald Weasley",
                "Hermione Granger",
                "Neville Longbottom",
                "Severus Snape",
                "Albus Dumbledore"
            };

            #region Example 1

            EvenNumberQuery evenNumberQuery = new EvenNumberQuery(numbers);

            foreach (int number in evenNumberQuery.GetEvenNumbersUsingMethodSyntax())
            {
                Console.WriteLine(number);
            }

            foreach (int number in evenNumberQuery.GetEvenNumbersUsingQuerySyntax())
            {
                Console.WriteLine(number);
            }

            #endregion

            #region Example 2

            RandomOrderQuery randomOrderQuery = new RandomOrderQuery(numbers);

            foreach (int number in randomOrderQuery.GetNumbersInRandomOrderUsingMethodSyntax())
            {
                Console.WriteLine(number);
            }

            foreach (int number in randomOrderQuery.GetNumbersInRandomOrderUsingQuerySyntax())
            {
                Console.WriteLine(number);
            }

            #endregion

            #region Example 3

            NameQuery nameQuery = new NameQuery(names);

            foreach (string name in nameQuery.GetNamesUsingMethodSyntax("H", "e"))
            {
                Console.WriteLine(name);
            }

            foreach (string name in nameQuery.GetNamesUsingQuerySyntax("H", "e"))
            {
                Console.WriteLine(name);
            }

            #endregion

            Console.Read();
        }
    }
}
