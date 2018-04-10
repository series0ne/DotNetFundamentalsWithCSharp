namespace LinqOrderBySample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Brian", "Uriel", "Yusuf", "Zayne", "Aaron",
                "David", "Eddie", "Micky", "Oscar", "Perry",
                "Frank", "Jacky", "Karen", "Gavin", "Hazel",
                "Issac", "Vidal", "Wayne", "Clair", "Nancy",
                "Rowan", "Quinn", "Lance", "Simon", "Trent"
            };

            IEnumerable<string> orderedNames = names
                .OrderBy(o => o);

            IEnumerable<string> orderedAndUpperCaseNames =
                from name in names
                orderby name
                select name.ToUpper();

            foreach(string name in orderedAndUpperCaseNames)
            {
                Console.WriteLine(name);
            }

            Console.Read();
        }
    }
}
