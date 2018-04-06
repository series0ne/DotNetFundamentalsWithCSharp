namespace IEnumerableSample
{
    using System.Collections;

    internal sealed class PeopleEnumerator : IEnumerator
    {
        private readonly Person[] people;
        int position = -1;

        public PeopleEnumerator(Person[] people)
        {
            this.people = people;
        }

        public object Current => people[position];

        public bool MoveNext() => ++position < people.Length;

        public void Reset() => position = -1;
    }
}
