namespace GreeterSample
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter1 = new Greeter("John");
            greeter1.Greet();

            Greeter greeter2 = new Greeter("Sally");
            greeter2.Greet();

            Console.Read();            
        }
    }
}
