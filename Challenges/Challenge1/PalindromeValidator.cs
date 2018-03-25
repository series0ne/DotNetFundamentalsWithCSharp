namespace Challenge1
{
    public sealed class PalindromeValidator
    {
        public PalindromeValidator(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public bool IsPalindromic
        {
            get
            {
                string value = Value.ToLower();

                for (int i = 0; i < value.Length / 2; i++)
                {
                    if (value[i] != value[value.Length - i - 1])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
