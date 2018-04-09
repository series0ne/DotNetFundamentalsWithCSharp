namespace LinqSample
{
    using System.Collections.Generic;
    using System.Linq;

    public sealed class EvenNumberQuery
    {
        private readonly IEnumerable<int> numbers;

        public EvenNumberQuery(IEnumerable<int> numbers)
        {
            this.numbers = numbers;
        }

        public IEnumerable<int> GetEvenNumbersUsingMethodSyntax()
        {
            return numbers.Where(number => number % 2 == 0);
        }

        public IEnumerable<int> GetEvenNumbersUsingQuerySyntax()
        {
            return from number in numbers
                   where number % 2 == 0
                   select number;
        }
    }
}
