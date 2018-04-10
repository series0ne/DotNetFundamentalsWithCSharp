namespace ExpandoObjectSample
{
    using System;
    using System.Dynamic;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            dynamic bag = new ExpandoObject();

            bag.FirstName = "John";
            bag.LastName = "Smith";
            bag.Birthday = new DateTime(1978, 03, 04);

            Console.WriteLine($"{bag.FirstName} {bag.LastName} was born on {bag.Birthday.ToShortDateString()}");
            Console.Read();
        }
    }
}
