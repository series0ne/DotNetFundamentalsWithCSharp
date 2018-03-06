namespace ShapeSample
{
    using System;

    public class Square : Shape, ISurfaceArea
    {
        public Square(double size, ConsoleColor color) : base(color)
        {
            Size = size;
        }

        public double Size { get; }

        public virtual double GetSurfaceArea()
        {
            return Size * Size;
        }
    }
}
