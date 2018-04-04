namespace Challenge3
{
    using System;

    public sealed class PairAndSum : IEquatable<PairAndSum>
    {
        public PairAndSum(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public int Value1 { get; }
        public int Value2 { get; }
        public int Sum => Value1 + Value2;

        public bool Equals(PairAndSum other)
        {
            return !(other is null)
                && Sum == other.Sum;
        }

        public override bool Equals(object obj) => Equals(obj as PairAndSum);

        public override int GetHashCode() => Sum.GetHashCode();

        public override string ToString() => $"{Value1} + {Value2} = {Sum}";
    }
}
