namespace ShapeSample
{
    using System;

    public class Circle : Shape, ISurfaceArea
    {
        public Circle(double radius, ConsoleColor color) : base(color)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public double GetSurfaceArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public override void WriteShapeInfo()
        {
            Console.Write("The circle is ");
            WriteShapeColor();
        }
    }
}
