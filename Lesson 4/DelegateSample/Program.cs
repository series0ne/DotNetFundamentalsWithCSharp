namespace DelegateSample
{
    using System;

    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            Calculate calculate = null;
            double answer;

            Console.Write("Enter first number: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double value2 = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+-*/): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch(op)
            {
                case '+':
                    calculate = Add;
                    break;
                case '-':
                    calculate = Subtract;
                    break;
                case '*':
                    calculate = Multiply;
                    break;
                case '/':
                    calculate = Divide;
                    break;
            }

            if(calculate != null)
            {
                answer = calculate(value1, value2);
                Console.WriteLine($"The answer is {answer}");
            }

            Console.Read();
        }

        private static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
