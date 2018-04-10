namespace ExtensionMethodSample
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            int x = 24;
            int xSquared = x.Square();
            Console.WriteLine($"{x} squared = {xSquared}");

            int y = 67;
            int yMultiplied = y.Multiply(12);
            Console.WriteLine($"{y} x 12 = {yMultiplied}");

            Console.Read();
        }
    }
}
