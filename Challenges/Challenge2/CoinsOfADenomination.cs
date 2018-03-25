namespace Challenge2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class CoinsOfADenomination
    {
        private readonly int[] denominations;

        public CoinsOfADenomination(IEnumerable<int> denominations)
        {
            this.denominations = denominations
                .OrderByDescending(i => i)
                .ToArray();
        }

        public int GetMinimumNumerOfCoins(int value)
        {
            int result = 0;
            
            foreach (int denomination in denominations)
            {
                result += value / denomination;
                value %= denomination;
            }

            if(value > 0)
            {
                throw new Exception("Unable to satisfy request.");
            }

            return result;
        }
    }
}
