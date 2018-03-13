namespace NullableValueTypeSample
{
    using System;

    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            int? numberOfCigarettesInAPack = null;

            Console.Write("Enter L for Large or S for Small: ");
            char size = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch(size)
            {
                case 'L':
                case 'l':
                    numberOfCigarettesInAPack = 20;
                    break;
                case 'S':
                case 's':
                    numberOfCigarettesInAPack = 10;
                    break;
            }

            if(numberOfCigarettesInAPack != null)
            {
                Console.WriteLine($"There are {numberOfCigarettesInAPack} in a packet of the specified size.");
            }
            else
            {
                Console.WriteLine("Unknown pack size");
            }

            Console.Read();
        }
    }
}
