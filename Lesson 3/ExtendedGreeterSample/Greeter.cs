namespace ExtendedGreeterSample
{
    using System;

    public class Greeter
    {
        public Greeter(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public virtual void Greet()
        {
            Console.WriteLine($"Hello, {Name}");
        }
    }
}
