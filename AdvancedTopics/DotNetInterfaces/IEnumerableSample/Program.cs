using System;

namespace IEnumerableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People(new Person[]
            {
                new Person("John", "Smith"),
                new Person("Jack", "Black")
            });

            foreach(Person person in people)
            {
                Console.WriteLine(person);
            }

            Console.Read();
        }
    }
}
