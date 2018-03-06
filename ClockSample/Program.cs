namespace ClockSample
{
    using System;
    using System.Threading;
    
    class Program
    {
        static void Main(string[] args)
        {
            Clock london = new Clock();
            london.SetTime(23, 59, 55);

            while(true)
            {
                Console.WriteLine($"London: {london.Hour:00}:{london.Minute:00}:{london.Second:00}");
                Thread.Sleep(1000);
                london.Tick();
                Console.Clear();
            }
        }
    }
}
