namespace IteratorStateMachineSample
{
    public sealed class ValueWrapper
    {
        public ValueWrapper(int value)
        {
            Value = value;
        }

        public int Value { get; set; }

        public static implicit operator int(ValueWrapper vw)
        {
            return vw.Value;
        }

        public static implicit operator ValueWrapper(int value)
        {
            return new ValueWrapper(value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
