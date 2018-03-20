namespace GenericSample
{
    using System;

    internal static class Program
    {
        private static Freezable<Seat> bookingSeat = new Freezable<Seat>();

        private static void Main(string[] args)
        {
            MakeBooking(bookingSeat, "Dave");
            MakeBooking(bookingSeat, "Chris");
        }

        private static void MakeBooking(Freezable<Seat> seat, string name)
        {
            seat.Value = new Seat();
            seat.Freeze();

            seat.Value.Book(name);
        }
    }
}
