namespace ShapeSample
{
    using System;

    public abstract class Shape
    {
        protected Shape(ConsoleColor color)
        {
            Color = color;
        }

        public ConsoleColor Color { get; }

        protected void WriteShapeColor()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(Color.ToString());
            Console.ResetColor();
        }

        public virtual void WriteShapeInfo()
        {
            Console.Write("The shape is ");
            WriteShapeColor();
        }
    }
}
