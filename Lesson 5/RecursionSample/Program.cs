namespace RecursionSample
{
    using System;

    internal static class Program
    {
        private static int counter = 0;

        private static void Main(string[] args)
        {
            Fibonacci(0, 1);

            //DirectoryEnumerator enumerator = new DirectoryEnumerator();

            //enumerator.Enumerate("C:\\");

            //foreach (string directory in enumerator.Directories)
            //{
            //    Console.WriteLine(directory);
            //}
            
            Console.Read();
        }

        private static void Fibonacci(int a, int b)
        {
            if(counter++ == 15)
            {
                return;
            }

            Console.Write($"{a}, ");
            Fibonacci(b, a + b);
        }
    }
}
