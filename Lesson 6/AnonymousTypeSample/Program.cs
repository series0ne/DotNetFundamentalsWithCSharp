namespace AnonymousTypeSample
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            var person = new
            {
                FirstName = "John",
                LastName = "Smith",
                Birthday = new DateTime(1978, 03, 04)
            };

            Console.WriteLine($"{person.FirstName} {person.LastName} was born on {person.Birthday.ToShortDateString()}");
            Console.Read();
        }
    }
}
