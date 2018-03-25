using System.Collections.Generic;

namespace Challenge3
{
    public sealed class Sum
    {
        private readonly int value;

        public Sum(int a, int b)
        {
            value = a + b;
        }

        public static IEnumerable<Sum> GetDistinctSums(int[] numbers)
        {
            HashSet<Sum> result = new HashSet<Sum>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    result.Add(new Sum(numbers[i], numbers[j]));
                }
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            Sum other = obj as Sum;
            return !(other is null)
                && value == other.value;
        }

        public override int GetHashCode() => value.GetHashCode();

        public override string ToString() => value.ToString();
    }
}
