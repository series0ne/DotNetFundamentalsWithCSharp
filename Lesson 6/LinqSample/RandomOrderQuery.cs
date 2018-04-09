namespace LinqSample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class RandomOrderQuery
    {
        private readonly IEnumerable<int> numbers;

        public RandomOrderQuery(IEnumerable<int> numbers)
        {
            this.numbers = numbers;
        }

        public IEnumerable<int> GetNumbersInRandomOrderUsingMethodSyntax()
        {
            return numbers.OrderBy(number => Guid.NewGuid());
        }

        public IEnumerable<int> GetNumbersInRandomOrderUsingQuerySyntax()
        {
            return from number in numbers
                   orderby Guid.NewGuid()
                   select number;
        }
    }
}
