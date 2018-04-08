namespace IEquatableSample
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            Person person1 = new Person("John", "Smith");
            object person2 = new Person("Jack", "Black");
            Person person3 = new Person("John", "Smith");

            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person2.Equals(person3));
            Console.WriteLine(person1 == person3);

            Console.Read();
        }
    }
}
