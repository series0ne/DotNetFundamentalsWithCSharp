using System;

namespace DynamicSample
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic value = null;
            string input;

            Console.Write("Enter a word or number: ");
            input = Console.ReadLine();

            if(double.TryParse(input, out double inputAsDouble))
            {
                value = inputAsDouble;
            }

            if (int.TryParse(input, out int inputAsInteger))
            {
                value = inputAsInteger;
            }

            if(value == null)
            {
                value = input;
            }

            Console.WriteLine($"{value.GetType().Name} : {value}");
            Console.Read();
        }
    }
}
