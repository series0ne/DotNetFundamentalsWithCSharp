namespace IEnumerableSample
{
    using System;
    using System.Collections;

    public sealed class People : IEnumerable
    {
        private readonly Person[] people;

        public People(Person[] people)
        {
            this.people = new Person[people.Length];
            Array.Copy(people, this.people, this.people.Length);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PeopleEnumerator(people);
        }
    }
}
