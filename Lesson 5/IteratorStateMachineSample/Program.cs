namespace IteratorStateMachineSample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            ValueWrapper[] values = new ValueWrapper[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<ValueWrapper> incrementedValues = Increment(values);

            while (true)
            {
                Console.Clear();

                foreach(ValueWrapper incrementedValue in incrementedValues)
                {
                    Console.WriteLine(incrementedValue);
                }

                Console.ReadKey();
            }
        }

        private static IEnumerable<ValueWrapper> Increment(ValueWrapper[] valueWrappers)
        {
            foreach(ValueWrapper valueWrapper in valueWrappers)
            {
                valueWrapper.Value++;
                yield return valueWrapper;
            }
        }
    }
}
