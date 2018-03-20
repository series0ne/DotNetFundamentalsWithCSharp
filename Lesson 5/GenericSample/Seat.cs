namespace GenericSample
{
    using System;

    public sealed class Seat
    {
        public string name;

        public void Book(string name)
        {
            this.name = name;
            Console.WriteLine($"Booking made for {name}");
        }
    }
}
