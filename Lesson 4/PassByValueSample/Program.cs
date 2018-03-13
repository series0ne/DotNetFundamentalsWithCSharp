namespace PassByValueSample
{
    using System;

    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            int value1 = 12;
            Square(value1);
            Console.WriteLine(value1);

            int value2 = 12;
            Square(ref value2);
            Console.WriteLine(value2);

            Console.Read();
        }

        private static void Square(int value)
        {
            value *= value;
        }

        private static void Square(ref int value)
        {
            value *= value;
        }
    }
}
