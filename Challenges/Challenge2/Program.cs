namespace Challenge2
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            CoinsOfADenomination coinsOfADenomination = new CoinsOfADenomination(new int[] { 50, 20, 5, 10, 2, 200, 100, 1 });

            Console.WriteLine(coinsOfADenomination.GetMinimumNumberOfCoins(1056));

            Console.Read();
        }
    }
}
