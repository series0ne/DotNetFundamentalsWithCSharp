namespace ShapeSample
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20, ConsoleColor.Red);
            Console.WriteLine($"The surface area of the rectangle is {rectangle.GetSurfaceArea()}");
            rectangle.WriteShapeInfo();

            Shape circle = new Circle(10, ConsoleColor.Blue);
            circle.WriteShapeInfo();

            Square square = new Square(50, ConsoleColor.Yellow);
            Console.WriteLine($"The surface area of the square is {square.GetSurfaceArea()}");
            square.WriteShapeInfo();

            Cube cube = new Cube(200, ConsoleColor.Green);
            Console.WriteLine($"The surface area of the cube is {cube.GetSurfaceArea()}");
            Console.WriteLine($"The volume of the cube is {cube.GetVolume()}");
            cube.WriteShapeInfo();

            Console.Read();
        }
    }
}
