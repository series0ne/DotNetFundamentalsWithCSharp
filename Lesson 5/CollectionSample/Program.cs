namespace CollectionSample
{
    using System;
    using System.Collections.Generic;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            List<string> names = new List<string>();

            AddNamesToCollection(names, "Alice", "Bob", "Charlie", "Bob", "Dave", "Alice");
            AddNamesToCollection(names, "Elizabeth");
            AddNamesToCollection(names, "Freddy", "Gareth");
            AddNamesToCollection(names, "Elizabeth", "Charlie", "Dave");

            IEnumerable<string> distinctNames = GetDistinctNames(names);

            foreach(string name in distinctNames)
            {
                Console.WriteLine(name);
            }

            Console.Read();
        }

        private static void AddNamesToCollection(ICollection<string> collection, params string[] names)
        {
            foreach (string name in names)
            {
                collection.Add(name);
            }
        }

        public static IEnumerable<string> GetDistinctNames(ICollection<string> collection)
        {
            return new HashSet<string>(collection);
        }
    }
}
