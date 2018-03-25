namespace Challenge1
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            PalindromeValidator[] validators = new PalindromeValidator[]
            {
                new PalindromeValidator("Level"),
                new PalindromeValidator("saippuakivikauppias"),
                new PalindromeValidator("Hello World"),
                new PalindromeValidator("Eve"),
                new PalindromeValidator("monitor"),
                new PalindromeValidator("Hannah"),
                new PalindromeValidator("Hanah"),
                new PalindromeValidator("hahnah")
            };

            foreach(PalindromeValidator validator in validators)
            {
                Console.WriteLine(validator.IsPalindromic);
            }

            Console.Read();
        }
    }
}
