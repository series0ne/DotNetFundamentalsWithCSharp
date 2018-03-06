namespace ExtendedGreeterSample
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            Greeter greeter1 = new Greeter("Alice");
            greeter1.Greet();

            Greeter greeter2 = new NightclubGreeter("Bob", 23);
            greeter2.Greet();

            Greeter greeter3 = new NightclubGreeter("Charlie", 16);
            greeter3.Greet();

            Greeter greeter4 = new BorderPatrolGreeter("David", "French");
            greeter4.Greet();

            Greeter greeter5 = new BorderPatrolGreeter("Aiofe", "Irish");
            greeter5.Greet();

            Greeter greeter6 = new BorderPatrolGreeter("Matthew", "South African");
            greeter6.Greet();

            Console.Read();
        }
    }
}
