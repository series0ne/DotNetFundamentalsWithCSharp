namespace IEquatableSample
{
    using System;

    public sealed class Person : IEquatable<Person>
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }

        public static bool operator ==(Person a, Person b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(Person a, Person b)
        {
            return !Equals(a, b);
        }

        public bool Equals(Person other)
        {
            return !(other is null)
                && FirstName == other.FirstName
                && LastName == other.LastName;
        }

        public override bool Equals(object obj) => Equals(obj as Person);

        public override int GetHashCode() => new { FirstName, LastName }.GetHashCode();

        public override string ToString() => $"{FirstName} {LastName}";
    }
}
