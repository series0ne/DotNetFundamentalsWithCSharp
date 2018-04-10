using System;

namespace ExceptionSample
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Rectangle rectangle1 = null;
            Rectangle rectangle2 = null;

            try
            {
                rectangle1 = new Rectangle(10, 20);
                rectangle2 = new Rectangle(-3, 40);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(rectangle1);
                Console.WriteLine(rectangle2);
            }

            Console.Read();
        }
    }
}
