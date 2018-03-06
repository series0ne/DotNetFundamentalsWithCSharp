namespace ShapeSample
{
    using System;

    public class Cube : Square, ISurfaceArea, IVolume
    {
        public Cube(double size, ConsoleColor color) : base(size, color)
        {
        }

        public override double GetSurfaceArea()
        {
            return (Size * Size) * 6;
        }

        public double GetVolume()
        {
            return Size * Size * Size;
        }
    }
}
