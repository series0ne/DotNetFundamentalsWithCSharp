namespace ShapeSample
{
    using System;

    public class Rectangle : Shape, ISurfaceArea
    {
        public Rectangle(double width, double height, ConsoleColor color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; }
        public double Height { get; }

        public double GetSurfaceArea()
        {
            return Width * Height;
        }

        public override void WriteShapeInfo()
        {
            Console.Write("The rectangle is ");
            WriteShapeColor();
        }
    }
}
