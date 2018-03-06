namespace ExtendedGreeterSample
{
    using System;

    public sealed class BorderPatrolGreeter : Greeter
    {
        public BorderPatrolGreeter(string name, string nationality) : base(name)
        {
            Nationality = nationality;
        }

        public string Nationality { get; }

        public override void Greet()
        {
            switch (Nationality)
            {
                case "English":
                    Console.WriteLine($"Hello, {Name}");
                    break;
                case "French":
                    Console.WriteLine($"Bonjour, {Name}");
                    break;
                case "Italian":
                    Console.WriteLine($"Caio, {Name}");
                    break;
                case "Irish":
                    Console.WriteLine($"Top o' the morning to you, {Name}");
                    break;
                default:
                    Console.WriteLine($"I don't know where you're from, {Name}. Please leave!");
                    break;
            }
        }
    }
}
