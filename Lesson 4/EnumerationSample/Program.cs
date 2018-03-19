using System;

namespace EnumerationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFruitColor(Fruit.Apple);
            PrintConsoleColors();

            Console.Read();
        }

        private static void PrintFruitColor(Fruit fruit)
        {
            string fruitColor = null;

            switch (fruit)
            {
                case Fruit.Apple:
                    fruitColor = "green";
                    break;
                case Fruit.Banana:
                    fruitColor = "yellow";
                    break;
                case Fruit.Grape:
                    fruitColor = "red";
                    break;
            }

            Console.WriteLine($"The fruit color is {fruitColor}");
        }

        private static void PrintConsoleColors()
        {
            ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));

            foreach (ConsoleColor color in colors)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"The console color is {color}. The underlying value is {(int)color}");
            }
        }
    }
}
