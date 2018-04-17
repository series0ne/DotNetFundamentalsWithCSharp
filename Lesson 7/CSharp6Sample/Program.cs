namespace CSharp6Sample
{
    using System;
    using System.Collections.Generic;
    using static System.Console;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<int, string> tradePrices = new Dictionary<int, string>()
            {
                { 1, "5 Magic Beans" },
                { 2, "10 Magic Beans" },
                { 3, "20 Magic Beans (Special Offer)" }
            };

            foreach(KeyValuePair<int, string> tradePrice in tradePrices)
            {
                WriteLine($"For {tradePrice.Key} cow, you will get {tradePrice.Value}");
            }

            Jack jack = new Jack();

            try
            {
                Write("Enter number of beans to trade for a cow: ");

                int beans;
                int.TryParse(ReadLine(), out beans);

                jack?.TradeCowForBeans(beans);

                WriteLine(jack);
            }
            catch(InvalidOperationException ex) when (ex.Message == "C'mon, Jack! Don't be greedy!")
            {
                WriteLine($"{nameof(Jack)} only had 1 cow. Jack was greedy!");
            }
            finally
            {
                Read();
            }
        }
    }
}
