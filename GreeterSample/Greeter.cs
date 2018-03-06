namespace GreeterSample
{
    using System;

    public class Greeter
    {
        private string name;

        public Greeter(string name)
        {
            this.name = name;
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
}
