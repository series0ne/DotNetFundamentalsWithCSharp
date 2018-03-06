namespace ExtendedGreeterSample
{
    using System;

    public sealed class NightclubGreeter : Greeter
    {
        public NightclubGreeter(string name, int age) : base(name)
        {
            Age = age;
        }

        public int Age { get; }

        public override void Greet()
        {
            if (Age >= 18)
            {
                Console.WriteLine($"Welcome, {Name}. Have a good evening!");
            }
            else
            {
                Console.WriteLine($"Sorry, {Name}. You're too young to come in!");
            }
        }
    }
}
