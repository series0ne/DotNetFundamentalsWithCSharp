namespace ArraySample
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[10];

            SetNumbers(numbers, 145);

            WriteNumbers(numbers);

            Console.Read();
        }

        private static void SetNumbers(int[] numbers, int start)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = start++;
            }
        }

        private static void WriteNumbers(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number at index {i} = {numbers[i]}");
            }
        }
    }
}
