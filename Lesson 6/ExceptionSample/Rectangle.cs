namespace ExceptionSample
{
    using System;

    public sealed class Rectangle
    {
        public Rectangle(int height, int width)
        {
            Height = height >= 0
                ? height
                : throw new ArgumentException("Height cannot be less than zero.");

            Width = width >= 0
                ? width
                : throw new ArgumentException("Width cannot be less than zero.");
        }

        public int Height { get; }
        public int Width { get; }

        public override string ToString() => $"{Width}x{Height}";
    }
}
