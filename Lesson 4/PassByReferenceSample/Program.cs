namespace PassByReferenceSample
{
    using System;

    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person("John", "Smith");
            ChangePersonName(person);
            Console.WriteLine($"{person.FirstName} {person.LastName}");

            string value1 = "Alice";
            string value2 = "Bob";

            // Why doesn't this do what you'd expect it to do when it's passing by reference?
            Reassign(value1, value2);
            Console.WriteLine($"value1 = {value1}, value2 = {value2}");

            Reassign(ref value1, ref value2);
            Console.WriteLine($"value1 = {value1}, value2 = {value2}");

            Console.Read();
        }

        private static void ChangePersonName(Person person)
        {
            person.FirstName = "Alice";
            person.LastName = "Henderson";
        }

        private static void Reassign(string a, string b)
        {
            a = b;
        }

        private static void Reassign(ref string a, ref string b)
        {
            a = b;
        }
    }
}
