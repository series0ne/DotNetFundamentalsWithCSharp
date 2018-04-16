using System;

namespace CSharp6Sample
{
    public sealed class Jack
    {
        public int Cows { get; private set; } = 1;
        public int MagicBeans { get; private set; } = 0;

        public void TradeCowForBeans(int beans)
        {
            if(beans <= 0)
            {
                throw new InvalidOperationException("C'mon, Jack! Don't give the cow away!");
            }

            if(beans > 5)
            {
                throw new InvalidOperationException("C'mon, Jack! Don't be greedy!");
            }

            Cows = 0;
            MagicBeans = beans;
        }

        public override string ToString() => $"Jack has {Cows} cows and {MagicBeans} magic beans";
    }
}
