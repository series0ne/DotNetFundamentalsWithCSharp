namespace ExtensionMethodSample
{
    public static class Int32Extensions
    {
        public static int Square(this int value)
        {
            return value * value;
        }

        public static int Multiply(this int value, int by)
        {
            return value * by;
        }
    }
}
